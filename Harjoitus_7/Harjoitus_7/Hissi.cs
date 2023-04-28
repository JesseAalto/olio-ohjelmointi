using Harjoitus_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_7;
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
