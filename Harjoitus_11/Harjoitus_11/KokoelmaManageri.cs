using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_11
{
    static class KokoelmaManageri
    {
        public static Dictionary<string, Opiskelija> Opiskelijat = new Dictionary<string, Opiskelija>();

        public static void LisääOpiskelija(string etunimi, string sukunimi)
        {
            bool sallittu = false;
            string opiskelijaID = "";

            while (!sallittu)
            {
                try
                {
                    Console.Write("OpiskelijaID: ");
                    opiskelijaID = Console.ReadLine();

                    sallittu = TarkistaID(opiskelijaID);

                }
                catch (OpiskelijaPoikkeus)
                {
                    
                }
            }

            if (sallittu)
            {
                Opiskelijat.Add(opiskelijaID, new Opiskelija(etunimi, sukunimi, opiskelijaID));
                TulostaViesti(string.Format("Uusi opiskelija {0} lisätty kokoelmaan!", Opiskelijat[opiskelijaID].HaeData()));
            }
        }

        public static bool TarkistaID(string id)
        {
            if (Opiskelijat.ContainsKey(id))
            {
                throw new OpiskelijaPoikkeus("OpiskelijaID " + id + " ei ole mitenkään uniikki, anna uusi ID");
            }
            else if (id.Length <= 4 || id.Length >= 6)
            {
                throw new OpiskelijaPoikkeus("OpiskelijaID " + id + " on liian pitkä tai lyhyt. Opiskelija ID:n pituus tulisi olla tasan 5");
            }
            else
            {
                return true;
            }
        }

        public static void PoistaOpiskelija(int syötettyIndex)
        {
            int i = 0;

            foreach (string avain in Opiskelijat.Keys)
            {
                if (i == syötettyIndex)
                {
                    TulostaViesti("Opiskelija " + Opiskelijat[avain].HaeData() + " poistettu kokoelmasta");
                    Opiskelijat.Remove(avain);
                    break;
                }

                i++;
            }
        }

        public static void TulostaKokoelma()
        {
            if (Opiskelijat.Count == 0)
            {
                TulostaViesti("Opiskelijakokoelma on tyhjä");
                return;
            }

            int i = 1;

            TulostaViesti("Opiskelijat kokoelmassa: ");

            foreach (Opiskelija opiskelija in Opiskelijat.Values)
            {
                Console.WriteLine("{0}: {1}", i, opiskelija.HaeData());
                i++;
            }
        }

        public static void TulostaViesti(string message)
        {
            Console.WriteLine();
            Console.WriteLine("----");
            Console.WriteLine(message);
        }
    }
}
