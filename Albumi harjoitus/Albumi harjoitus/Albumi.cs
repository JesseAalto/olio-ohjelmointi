using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albumi_harjoitus
{
    internal class Albumi
    {
        public string Artisti { get; set; }

        public string Nimi { get; set; }

        public string Genre { get; set; }

        public int Hinta { get; set; }

        private List<Kappale> Kappaleet = new List<Kappale>();

        public Albumi(string artisti, string nimi, string genre, int hinta)
        {
            Artisti = artisti;
            Nimi = nimi;
            Genre = genre;
            Hinta = hinta;

        }
        public void LisääKappale(Kappale kappale)
        {
            Kappaleet.Add(kappale);
        }
        public void TulostaKappaleet()
        {
            foreach (Kappale kappale in Kappaleet)
            {
                kappale.TulostaTiedot();
            }


        }
            public void TulostaAlbumi()
            {
                Console.WriteLine();
                Console.WriteLine("Albumi: ");
                Console.WriteLine(" Artisti - " + Artisti);
                Console.WriteLine(" Albumin nimi - " + Nimi);
                Console.WriteLine(" Genre - " + Genre);
                Console.WriteLine(" Hinta - " + Hinta);
                Console.WriteLine(" Kappaleet: ");
                TulostaKappaleet();
            }
    }

}
