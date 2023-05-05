
namespace GestoreCitazioni
{
    public class Citazione
    {
        public int Id { get => id; set => id = value; }
        public string Titolo { get => titolo; set => titolo = value; }
        public string Autore { get => author.NomeCompleto; }
        public string Cit { get => cit; set => cit = value; }
        public String Comment { get => comment; }
        public String Typo { get => typo; }
        public String Data { get => data.ToShortDateString();}

        private int id;
        private string titolo;
        private string cit;
        public Author author;
        private DateTime data;
        private string comment;
        private string typo;

        public Citazione(string tit, string cit, DateTime dt, string typo, int auth, string comment)
        {
            Titolo = tit;
            Cit = cit;
            this.data = dt;
            author = db_Cits.getAuthorsData(auth);
            this.comment = comment;
            this.typo = typo;
        }
        public Citazione(int id, string tit, string cit, DateTime dt, string typo, int auth, string comment)
        {
            Id = id;
            Titolo = tit;
            Cit = cit;
            data = dt;
            author = db_Cits.getAuthorsData(auth);
            this.comment = comment;
            this.typo = typo;
        }
        public Citazione(){}

        public void save()
        {
            db_Cits.updateCit(this);
        }

        public void delete()
        {
            db_Cits.deleteCit(this);
        }

    }
}
