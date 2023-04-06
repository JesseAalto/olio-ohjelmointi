using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Opiskelija_harjoitus2
{
    internal class Opiskelija
    {
        // Opiskelija -olion muuttuja

        public string Nimi { get; set; }

        public string OpiskelijaID { get; set; }

        public int Opintopisteet { get; set; }

        


        public Opiskelija(string _nimi, string _OpiskelijaID, int _Opintopisteet)
        {
            Nimi = _nimi;
            OpiskelijaID = _OpiskelijaID;
            Opintopisteet = _Opintopisteet;
           
        }


        public string HaeTiedot()
        {
            string Opiskelijatiedot = "Nimi: " + Nimi + ". OpiskelijaID: " + OpiskelijaID + ". Opintopisteet: " + Opintopisteet.ToString();

            return Opiskelijatiedot;


        }
        public int MuokkaaOpintopisteet()
        {
            Opintopisteet = 2;

            return Opintopisteet; 
        }

    }


}