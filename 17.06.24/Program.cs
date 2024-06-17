using System.Runtime.CompilerServices;

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

            public void Descrizione()
            {

                Console.WriteLine("L'atleta si chiama " + nome + " " + cognome + " ha " + eta + " anni e non pratica " + sport);
            }
        }

        class Dipendente
        {
            string nome = "";
            string cognome = "";
            int eta;
            string lavoro = "";

            public string Nome { get { return nome; } set { nome = value; } }
            public string Cognome { get { return cognome; } set { cognome = value; } }
            public int Eta { get { return eta; } set { eta = value; } }

            public string Lavoro { get { return lavoro; } set { lavoro = value; } }

            public void Descrizione()
            {
                Console.WriteLine("Il dipendente " + nome + " " + cognome + " ha " + eta + " anni, con occupazione: " + lavoro);
            }
        }

        class Veicolo
        {
            string marca = "";
            int anno_immatricolazione;
            string colore = "";

            public string Marca { get { return marca; } set { marca = value; } }
            public int Anno_immatricolazione { get { return anno_immatricolazione; } set { anno_immatricolazione = value; } }
            public string Colore { get { return colore; } set { colore = value; } }

            public void Descrizione()
            {
                Console.WriteLine(" L' " + marca + " " + " di anno: " + anno_immatricolazione + " di colore: " + colore);
            }
        }

        class Animale
        {
            string razza = "";
            string colore = "";

            public string Razza { get { return razza; } set { razza = value; } }
            public string Colore { get { return colore; } set { colore = value; } }

            public void Descrizione()
            {
                Console.WriteLine("L'" + razza + " e' di colore " + colore);
            }
            static void Main(string[] args)
            {
                Atleta atleta = new Atleta();
                atleta.Nome = "Salvatore";
                atleta.Cognome = "Rossi";
                atleta.Eta = 26;
                atleta.Sport = "Nuoto";

                atleta.Descrizione();

                Dipendente dipendente = new Dipendente();
                dipendente.Nome = "Giovanni";
                dipendente.Cognome = "Mercurio";
                dipendente.Eta = 45;
                dipendente.Lavoro = "Contabile";

                dipendente.Descrizione();

                Animale animale = new Animale();
                animale.razza = "elefante";
                animale.colore = "rosa";

                animale.Descrizione();

                Veicolo  veicolo = new Veicolo();
                veicolo.Marca = "Audi";
                veicolo.Anno_immatricolazione = 2022;
                veicolo.Colore = " grigio opaco ";

                veicolo.Descrizione();

            }
        }
    }
}
