namespace _17._06._24
{
    internal class Program
    {
        class Atleta
        {
            string nome = "";
            string cognome = "";
            int eta;
            string sport = "";

            public string Nome { get { return nome; } set { nome = value; } }
            public string Cognome { get { return cognome; } set { cognome = value; } }
            
            public int Eta { get { return eta; } set { eta = value; } }

            public string Sport { get { return sport; } set { sport = value; } }

            public void Descrizione() {

                Console.WriteLine("L'atleta si chiama " + nome + " " + cognome + " ha " + eta + " anni e non pratica " + sport);
            }
        }
        static void Main(string[] args)
        {
            Atleta atleta = new Atleta();
            atleta.Nome = "Salvatore";
            atleta.Cognome = "Rossi";
            atleta.Eta = 26;
            atleta.Sport = "Nuoto";

            atleta.Descrizione();
        }
    }
}
