using System;

namespace Harjoitus_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string lukija = "";

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Anna komento (Näytä, Lisää, Poista tai Poistu) > ");
                lukija = Console.ReadLine().ToLower();

                switch (lukija)
                {
                    case "näytä":
                        KokoelmaManageri.TulostaKokoelma();
                        break;
                    case "lisää":
                        Lisää();
                        break;
                    case "poista":
                        Poista();
                        break;
                    case "poistu":
                        Console.WriteLine("Poistutaan sovelluksesta");
                        return;
                    default:
                        Console.WriteLine("Virheellinen syöttö, yritä uudelleen");
                        break;
                }
            }
        }

        static void Lisää()
        {
            string etunimi = "";
            string sukunimi = "";

            Console.WriteLine();
            Console.WriteLine("----");
            Console.WriteLine("Anna uuden Opiskelijan tiedot: ");
            Console.WriteLine();

            Console.Write("Etunimi: ");
            etunimi = Console.ReadLine();

            Console.Write("Sukunimi: ");
            sukunimi = Console.ReadLine();

            KokoelmaManageri.LisääOpiskelija(etunimi, sukunimi);
        }

        static void Poista()
        {
            if (KokoelmaManageri.Opiskelijat.Count == 0)
            {
                Console.WriteLine("Opiskelija kokoelma on tyhjä!");
                return;
            }

            KokoelmaManageri.TulostaKokoelma();

            int lukijaIndex;
            int opiskelijaMäärä = KokoelmaManageri.Opiskelijat.Count;

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Kenet haluat poistaa? Valitse väliltä {0} - {1} > ", 1, opiskelijaMäärä);

                bool result = int.TryParse(Console.ReadLine(), out lukijaIndex);

                if (result)
                {
                    if (lukijaIndex <= opiskelijaMäärä && lukijaIndex > 0)
                    {
                        KokoelmaManageri.PoistaOpiskelija(lukijaIndex - 1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Virhe valinnassa, anna uusi valinta");
                    }
                }
                else
                {
                    Console.WriteLine("Virheellisesti annettu syöttö. Syötöksi kelpaa vain numerot!");
                }
            }
        }
    }
}