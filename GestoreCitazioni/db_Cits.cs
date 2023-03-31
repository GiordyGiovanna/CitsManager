using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;
using System.Data;

namespace GestoreCitazioni
{
    internal static class db_Cits
    {
        public static List<Citazione> Allcits { get => allCits.Count > 0 ? allCits : readfile(); }

        private static List<Citazione> allCits = new List<Citazione>();

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
                                reader.GetInt32(5),
                                reader.GetString(3)));
                        }
                    }
                }
                connection.Close();
            }
            allCits = citazioni;
            return citazioni;
        }

        public static void saveNewCit(Citazione c)
        {
            List<Citazione> citazioni = new List<Citazione>();

            // I have to convert to the correct datetime (YYYY/MM/DD)
            string dateInTheCorretFormat = DateTime.Now.ToShortDateString();
            dateInTheCorretFormat = dateInTheCorretFormat.Split('/')[2] + "/" + dateInTheCorretFormat.Split('/')[1] + "/" + dateInTheCorretFormat.Split('/')[0];
            
            // I love this query, it returns the new record's ID
            String sql = $"INSERT INTO citazioni OUTPUT INSERTED.idCit VALUES('{c.Titolo}', '{c.Cit}', '{c.Comment}', '{dateInTheCorretFormat}', {c.author.Id}) ";
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
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
            String sql = "SELECT * FROM Authors Where idAuthor = " + idAuthor.ToString();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
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
                    }
                }
                connection.Close();
            
            }
            return autore == null ? throw new Exception("Autore mancante") : autore;
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
                    }
                }
                connection.Close();
            }
            return Authors;
        }

        public static void updateCit(Citazione c)
        {
            String sql = $"UPDATE citazioni SET descr = '{c.Cit}' WHERE idCit = {c.Id}";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()){}
                }
                connection.Close();
            }

            allCits.Find(x => x.Id == c.Id).Cit = c.Cit;
        }

        public static void deleteCit(Citazione c)
        {
            String sql = $"DELETE citazioni WHERE idCit = {c.Id}";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings.Get("dbConnection")))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader()) { }
                }
                connection.Close();
            }

            allCits.Remove(c);
        }
    }
}
