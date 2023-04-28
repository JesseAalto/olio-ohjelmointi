using Harjoitus7;

internal class Program
{
    static void Main(string[] args)
    {
        Hissi hissi = new Hissi(1, 6);


        int uusiKerros = 0;


        while (true)
        {
            Console.WriteLine();
            Console.Write("Anna uusi kerros 1-6: ", hissi.PalautaMinMax());

            bool tarkista = int.TryParse(Console.ReadLine(), out uusiKerros);

            if (tarkista)
            {
                hissi.Kerros = uusiKerros;
            }


            hissi.TulostaKerros();
        }


    }
    internal class Hissi
    {
        private int kerros;

        private int minKerros;
        private int maxKerros;

        public int Kerros
        {
            set
            {
                if (value < minKerros)
                {
                    Virhe.KirjoitaError("Virheellinen kerros annettu.");
                }
                else if (value > maxKerros)
                {
                    Virhe.KirjoitaError("Virheellinen kerros annettu.");
                }
                else
                {
                    kerros = value;
                }
            }
        }

        public Hissi(int _minKerros, int _maxKerros)
        {
            minKerros = _minKerros;
            maxKerros = _maxKerros;
        }

        public void TulostaKerros()
        {
            Console.WriteLine("Nykyinen kerros on " + kerros);
        }

        public string PalautaMinMax()
        {
            return minKerros + "-" + maxKerros;
        }
    }
}