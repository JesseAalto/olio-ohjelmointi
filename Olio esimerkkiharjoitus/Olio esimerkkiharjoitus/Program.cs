using Olio_esimerkkiharjoitus;

internal class Program
{
    static void Main(string[] args)
    {
        Koira KoiraOlio = new Koira("Rekku", "Saksanpaimenkoira", 4, "Harmaa", 32.0f);

        KoiraOlio.Nimi =  "Rekku";
        KoiraOlio.rotu = "Saksanpaimenkoira";
        KoiraOlio.ikä = 4;
        KoiraOlio.Väri = "Ruskea";
        KoiraOlio.paino = 32.0f;

        KoiraOlio.Hauku();

        Console.WriteLine(KoiraOlio.HaeTiedot());

        KoiraOlio.Hauku();

    }

}