using Harjoitus_5;

namespace Harjoitus_5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 10.0f;
            float b = 5.5f;

            float summa = Laskin.Summa(a, b);
            float erotus = Laskin.Erotus(a, b);
            float kertolasku = Laskin.Kertolasku(a, b);
            float jakolasku = Laskin.Jakolasku(a, b);

            Console.WriteLine("Numeroiden {0} ja {1}:", a, b + "\nSumma: " + summa + "\nErotus: " + erotus + "\nKertolasku: " + kertolasku + "\nJakolasku: " + jakolasku);
        }
    }
}