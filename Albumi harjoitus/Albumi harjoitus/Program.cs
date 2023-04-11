using Albumi_harjoitus;

internal class Program
{
    private static void Main(string[] args)
    {
        Albumi albumi = new Albumi("Imagine Dragons", "Evolve", "Pop-rock", 10);

        albumi.LisääKappale(new Kappale("Next To Me", "3:50"));
        albumi.LisääKappale(new Kappale("I Dont Know Why", "3:10"));
        albumi.LisääKappale(new Kappale("Whatever It Takes", "3:21"));
        albumi.LisääKappale(new Kappale("Believer", "3:24"));

        albumi.TulostaAlbumi();
        

    }
}