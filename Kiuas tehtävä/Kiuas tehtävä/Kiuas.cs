using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiuas_tehtävä
{
    internal class Kiuas
    {
        // Kiuas -olion muuttuja

        public string Päälle { get; set; }

        public string Pois { get; set; }

        public int Lämpötila { get; set; }

        public int Kosteus {get; set; }




        public Kiuas(string _Päälle, string _Pois, int _Lämpötila, int _Kosteus)
        {
            Päälle = _Päälle;
            Pois = _Pois;
            Lämpötila = _Lämpötila;
            Kosteus = _Kosteus;  
        }


        public string HaeTiedot()
        {
            string Kiuastiedot = "Päälle: " + Päälle + ".Pois: " + Pois + ". Lämpötila: " + Lämpötila.ToString();   

            return Kiuastiedot;


        }
        public int 
        {
           string Kosteus 
        }

    }


}
