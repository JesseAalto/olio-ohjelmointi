using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Albumi_harjoitus
{
    internal class Kappale
    {
        public string Nimi;
        public string Kesto;

        public Kappale(string nimi, string kesto)
        {
            Nimi = nimi;
            Kesto = kesto;

            
        }

        public void TulostaTiedot()
        {
            Console.WriteLine(" -" + Nimi + " - " + Kesto + "minuuttia");
        }

 
       
    }
}
