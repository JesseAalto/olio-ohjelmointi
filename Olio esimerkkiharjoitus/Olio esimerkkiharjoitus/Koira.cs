using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_esimerkkiharjoitus
{
    internal class Koira
    {
        // koira -olion muuttuja

        public string Nimi { get; set; }

        public string rotu { get; set; }

        public int ikä { get; set; }

        public String Väri { get; set; }

        public float paino { get; set; }


        public Koira(string _nimi, string _rotu, int _ikä, string _väri, float _paino)
        {
            Nimi = _nimi;
            rotu = _rotu;
            ikä = _ikä;
            Väri = _väri;
            paino = _paino;
        }


        public string HaeTiedot()
        {
            string Koirantiedot = "Nimi: " + Nimi + ". Rotu: " + rotu + ". Ikä: " + ikä.ToString() + ". Väri: " + Väri + ". Paino: " + paino.ToString();

            return Koirantiedot;


        }
        public void Hauku()
        {
            Console.WriteLine("Woof Woof");
        }

    }           


}
