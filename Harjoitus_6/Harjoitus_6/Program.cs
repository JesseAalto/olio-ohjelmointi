public class Program
{
    public static void Main()
    {
        Kissa katti = new Kissa();
        Koira hauva = new Koira();
        Kirahvi kirahvi = new Kirahvi();

        Console.WriteLine(katti.Liiku());
        Console.WriteLine(hauva.Liiku());
        Console.WriteLine(kirahvi.Liiku());

        Elain.TulostaElaimiaYhteensa();
    }
}