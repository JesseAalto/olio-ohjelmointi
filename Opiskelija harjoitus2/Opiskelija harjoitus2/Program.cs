using Opiskelija_harjoitus2;
internal class Program
{
    static void Main(string[] args)
    {
        Opiskelija OpiskelijaOlio = new Opiskelija("Pekka", "21", 4);

        OpiskelijaOlio.Nimi = "Pekka";
        OpiskelijaOlio.OpiskelijaID = "21";
        OpiskelijaOlio.Opintopisteet = 4;

        Console.WriteLine(OpiskelijaOlio.HaeTiedot());

        OpiskelijaOlio.MuokkaaOpintopisteet();

        Console.WriteLine(OpiskelijaOlio.HaeTiedot());


    }
}