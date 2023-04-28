using Harjoitus_7;

static void Main(string[] args)
{
    Hissi hissi = new Hissi(1, 6);


    int uusiKerros = 0;


    while (true)
    {
        Console.WriteLine();
        Console.Write("Anna uusi kerros 1-6: ", hissi.PalautaMinMax());

        bool tarkista = int.TryParse(Console.ReadLine(), out uusiKerros);

        if (tarkista)
        {
            hissi.Kerros = uusiKerros;
        }


        hissi.TulostaKerros();
    }


}