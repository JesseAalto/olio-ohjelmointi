using Harjoitus_3;

internal class Program
{
    static void Main(string[] args)
    {
        // Luodaan Kiuas-olio ja käytetään sen metodeja eri arvoilla
        Kiuas saunaKiuas = new Kiuas("Saunakeidas");

        saunaKiuas.TulostaTiedot();

        saunaKiuas.VaihdaLampotila(75);
        saunaKiuas.VaihdaKosteus(70);
        saunaKiuas.VaihdaTila();

        Console.WriteLine("\nMuutettu tilanne:");
        saunaKiuas.TulostaTiedot();

        Console.ReadLine();
    }
}