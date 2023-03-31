using Harjoituss1; 

internal class Program
{
    static void Main(string[] args)
    {
        auto AutoOlio = new auto();
        
        AutoOlio.Nimi = "Maatti ";
        AutoOlio.Nopeus = 100;
        AutoOlio.Renkaat =  4;

        Console.WriteLine(AutoOlio.TulostaData());
    }
}