using Harjoitus_12;
class Ohjelma
{
    static void Main()
    {
        Korttipakka pakka = new Korttipakka();
        pakka.TulostaKortit();
        pakka.SekoitaKortit();
        Console.WriteLine("\nKortit on sekoitettu:");
        pakka.TulostaKortit();
    }
}