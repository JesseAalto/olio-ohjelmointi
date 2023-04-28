using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Elain
{
    static int elaimiaYhteensa = 0;

    public Elain()
    {
        elaimiaYhteensa++;
    }

    public virtual string Liiku()
    {
        return "Eläin liikkuu";
    }

    public static void TulostaElaimiaYhteensa()
    {
        Console.WriteLine("Eläimiä yhteensä: " + elaimiaYhteensa);
    }
}
