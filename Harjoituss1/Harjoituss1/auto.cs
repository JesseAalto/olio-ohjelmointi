using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoituss1
{
    internal class auto
    {
        public string Nimi { get; set; }

        public int Nopeus { get; set; }

        public int Renkaat { get; set; }

        // Tällä metodilla noudatetaan olemassa olevaa auto- olion tietoja

        public string TulostaData()
        {
            string AutonTiedot = "Nimi: " + Nimi + "Nopeus: " + Nopeus.ToString() + " Renkaat: " + Renkaat.ToString();

            return AutonTiedot;



        }





    }
}
