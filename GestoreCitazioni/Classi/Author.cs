
namespace GestoreCitazioni
{
    public class Author
    {
        public int Id { get => id; set => id = value; }
        public string NomeCompleto { get => nome + " " + cognome;}
        public string? Provenienza { get => provenienza; set => provenienza = value; }
        
        private int id;
        private string? nome;
        public string? cognome;
        public string? provenienza;

        public override String ToString()
        {
            return this.NomeCompleto;
        }

        public Author(int id, string nome, string cognome, string provenienza)
        {
            this.id = id;
            this.nome = nome;
            this.cognome = cognome;
            this.provenienza = provenienza;
        }
        public string ToExportString()
        {
            string s = $"{this.id};{this.nome};{this.cognome};{this.provenienza}".Replace("\r\n", "~").Replace("\r", "Σ").Replace("\n", "σ");
            return s;
        }
    }
}
