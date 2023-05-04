using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_12
{

    class Korttipakka
    {
        private List<string> kortit;

        public Korttipakka()
        {
            kortit = new List<string>();
            LisaaKortit();
        }

        private void LisaaKortit()
        {
            string[] maat = { "Hertta", "Risti", "Ruutu", "Pata" };
            string[] numerot = { "ässä", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };

            foreach (string maa in maat)
            {
                foreach (string numero in numerot)
                {
                    kortit.Add(numero + " " + maa);
                }
            }
        }

        public void TulostaKortit()
        {
            foreach (string kortti in kortit)
            {
                Console.WriteLine(kortti);
            }
        }

        public void SekoitaKortit()
        {
            Random rng = new Random();
            int n = kortit.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string kortti = kortit[k];
                kortit[k] = kortit[n];
                kortit[n] = kortti;
            }
        }

    }
}