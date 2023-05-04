using System;
using System.IO;

namespace Harjoitus_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string lukija;
            string filePath = @"c:\testi14\harjoitus14.txt";

            try
            {
                

                if (!File.Exists(filePath))
                {
                    using (StreamWriter sw = File.CreateText(filePath))
                    {
                        sw.WriteLine("Muistiinpanot: ");
                    }
                }

                bool poistutaanko = false;

                while (!poistutaanko)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Anna komento (Lisää, Näytä, Poista, Poistu) > ");
                    lukija = Console.ReadLine().ToLower();

                    switch (lukija)
                    {
                        case "lisää":
                            LisääMuistiinpano(filePath);
                            break;
                        case "näytä":
                            NäytäMuistiinpanot(filePath);
                            break;
                        case "poista":
                            PoistaMuistiinpanot(filePath);
                            break;
                        case "poistu":
                            poistutaanko = true;
                            return;
                        default:
                            Console.WriteLine("Annettu commandi on virheellinen, anna uusi command!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void LisääMuistiinpano(string filePath)
        {
            string lukija = "";

            Console.WriteLine("Kirjoita uusi muistiinpano: ");
            Console.WriteLine();
            lukija = Console.ReadLine();

            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(lukija);
            }
        }

        static void PoistaMuistiinpanot(string filePath)
        {
            File.WriteAllText(filePath, "Muistiinpanot: ");
        }

        static void NäytäMuistiinpanot(string filePath)
        {
            Console.WriteLine();
            string[] rivit = File.ReadAllLines(filePath);

            foreach (string rivi in rivit)
            {
                Console.WriteLine(rivi);
            }
        }
    }
}
