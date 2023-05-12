using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;
using System.Data;

namespace GestoreCitazioni
{
    internal static class db_Cits
    {
        public static List<Citazione> Allcits { get => allCits.Count > 0 ? allCits : readfile(); }
        public static List<Author> AllAuthors { get => allAuthors.Count > 0 ? allAuthors : getAllAuthorsData(); }

        private static List<Citazione> allCits = new List<Citazione>();
        private static List<Author> allAuthors = new List<Author>();

        public static List<Citazione> readfile()
        {
            List<Citazione> citazioni = new List<Citazione>();
            String sql = "SELECT * FROM citazioni";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            citazioni.Add(new Citazione(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetDateTime(4),
                                reader.GetString(5),
                                reader.GetInt32(6),
                                reader.GetString(3)));
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            }
            allCits = citazioni;
            return citazioni;
        }

        public static void saveNewCit(Citazione c, bool isImport = false)
        {
            List<Citazione> citazioni = new List<Citazione>();

            // I love this query, it returns the new record's ID
            String sql = $"INSERT INTO citazioni OUTPUT INSERTED.idCit VALUES(@titolo, @cit, @comment, @data, @typo, @autore) ";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@titolo", SqlDbType.VarChar);
                    command.Parameters["@titolo"].Value = c.Titolo;
                    command.Parameters.Add("@cit", SqlDbType.VarChar);
                    command.Parameters["@cit"].Value = c.Cit;
                    command.Parameters.Add("@comment", SqlDbType.VarChar);
                    command.Parameters["@comment"].Value = c.Comment;
                    command.Parameters.Add("@data", SqlDbType.DateTime);
                    command.Parameters["@data"].Value = !isImport ? DateTime.Now : c.Data;
                    command.Parameters.Add("@typo", SqlDbType.VarChar);
                    command.Parameters["@typo"].Value = c.Typo;
                    command.Parameters.Add("@autore", SqlDbType.Int);
                    command.Parameters["@autore"].Value = c.author.Id;
                    connection.Open();
                    c.Id = (int)command.ExecuteScalar();
                }
                connection.Close();
            }
            allCits.Add(c);
        }

        public static Author getAuthorsData(int idAuthor)
        {
            Author autore = null;
            String sql = "SELECT * FROM Authors Where idAuthor = @idAuthor";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.Add("@idAuthor", SqlDbType.VarChar);
                    command.Parameters["@idAuthor"].Value = idAuthor.ToString();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            autore = new Author(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3));
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            
            }
            return autore;
        }

        public static Author getAuthorInLike(string authorsText)
        {
            Author autore = null;
            String sql = $"SELECT * FROM Authors Where nome LIKE @authorsText OR cognome LIKE @authorsText";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.Add("@authorsText", SqlDbType.VarChar);
                    command.Parameters["@authorsText"].Value = authorsText;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            autore = new Author(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3));
                        }
                        reader.Close();
                    }
                }
                connection.Close();

            }
            return autore;
        }

        public static List<Author> getAllAuthorsData()
        {
            List<Author> Authors = new List<Author>();
            String sql = "SELECT * FROM Authors";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Authors.Add(new Author(
                                reader.GetInt32(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetString(3)));
                        }
                        reader.Close();
                    }
                }
                connection.Close();
            }
            allAuthors = Authors;
            return Authors;
        }

        public static void updateCit(Citazione c)
        {
            String sql = $"UPDATE citazioni SET descr = @cit WHERE idCit = @idCit";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.Add("@cit", SqlDbType.VarChar);
                    command.Parameters["@cit"].Value = c.Cit;
                    command.Parameters.Add("@idCit", SqlDbType.Int);
                    command.Parameters["@idCit"].Value = c.Id;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Close();
                    }

                }
                connection.Close();
            }

            allCits.Find(x => x.Id == c.Id).Cit = c.Cit;
        }

        public static int addNewAuthor(string nome, string cognome, string comesFrom, string eta = "")
        {
            String sql = eta != String.Empty ? 
                $"INSERT INTO Authors (nome, cognome, provenienza, etaCit) OUTPUT INSERTED.idAuthor VALUES (@nome, @cognome, @comesFrom, @eta)" :
                $"INSERT INTO Authors (nome, cognome, provenienza) OUTPUT INSERTED.idAuthor VALUES (@nome, @cognome, @comesFrom)";

            int id;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@nome", SqlDbType.VarChar);
                    command.Parameters["@nome"].Value = nome;
                    command.Parameters.Add("@cognome", SqlDbType.VarChar);
                    command.Parameters["@cognome"].Value = cognome;
                    command.Parameters.Add("@comesFrom", SqlDbType.VarChar);
                    command.Parameters["@comesFrom"].Value = comesFrom;
                    if(eta != String.Empty)
                    {
                        command.Parameters.Add("@eta", SqlDbType.Int);
                        command.Parameters["@eta"].Value = eta;
                    }
                    connection.Open();
                    id = (int)command.ExecuteScalar();

                }
                connection.Close();
            }
            allAuthors.Add(getAuthorsData(id));
            return id;
        }

        public static void deleteCit(Citazione c)
        {
            String sql = $"DELETE citazioni WHERE idCit = @idCit";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.Parameters.Add("@idCit", SqlDbType.Int);
                    command.Parameters["@idCit"].Value = c.Id;
                    using (SqlDataReader reader = command.ExecuteReader()) 
                    {
                        reader.Close();
                    }
                }
                connection.Close();
            }
            allCits.Remove(c);
        }

        public static void massiveImport(string csvFile)
        {
            String sqlDelete = $"DROP TABLE citazioni;DROP TABLE Authors;CREATE TABLE Authors(idAuthor int primary key identity(1,1),nome varchar(40) NOT NULL,cognome varchar(40) NOT NULL,provenienza varchar(40) NOT NULL,tetaCit int)CREATE TABLE citazioni(idCit int primary key identity(1,1),title varchar(80) NOT NULL,descr varchar(6000) NOT NULL,comment varchar(6000) NOT NULL,lastModified datetime NOT NULL,typo varChar(40) NOT NULL,idAuthor int FOREIGN KEY REFERENCES Authors(idAuthor) NOT NULL)";
            db_Cits.allCits = new List<Citazione>();
            db_Cits.allAuthors = new List<Author>();
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sqlDelete, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

            string strAuthors = csvFile.Split("///////////////////////////////////////////////////////////////////")[0];
            string strCits = csvFile.Split("///////////////////////////////////////////////////////////////////")[1];
            string[] strListAuthors = strAuthors.Split("\n");
            string[] strListCits = strCits.Split("\n");
            foreach (string author in strListAuthors)
            {
                string[] authorsData = author.Split(";");
                if (authorsData[0].Length > 0)
                {
                    addNewAuthor(authorsData[1], authorsData[2], authorsData[3]);
                }
            }
            foreach (string cit in strListCits)
            {
                if (cit.Contains(';'))
                {
                    string[] citData = cit.Split(";");
                    Citazione c = new Citazione(citData[1], citData[2], new DateTime(int.Parse(citData[4].Split('/')[2].Split(' ')[0]), int.Parse(citData[4].Split('/')[1]), int.Parse(citData[4].Split('/')[0]) ), citData[6], int.Parse(citData[5]), citData[3]);
                    saveNewCit(c, true);
                }
            }
        }
    }
}
