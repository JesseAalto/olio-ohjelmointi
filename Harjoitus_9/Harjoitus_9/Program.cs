class Radio
{
    private bool OnkoPaalla { get; set; }
    private int Aanenvoimakkuus { get; set; }
    private double Taajuus { get; set; }

    // Konstruktori
    public Radio()
    {
        OnkoPaalla = false;
        Aanenvoimakkuus = 5; // Oletusäänenvoimakkuus
        Taajuus = 88.0; // Oletustaajuus
    }

    // Metodi radion päälle laittamiseksi tai pois ottamiseksi
    public void VaihdaVirta()
    {
        OnkoPaalla = !OnkoPaalla;
        string status = OnkoPaalla ? "Päällä" : "Pois";
        Console.WriteLine($"Radio on nyt {status}");
    }

    // Metodi äänenvoimakkuuden säätämiseksi
    public void SaataAanenvoimakkuus(int aanenvoimakkuus)
    {
        if (aanenvoimakkuus >= 0 && aanenvoimakkuus <= 9)
        {
            Aanenvoimakkuus = aanenvoimakkuus;
            Console.WriteLine($"Äänenvoimakkuus on nyt: {Aanenvoimakkuus}");
        }
        else
        {
            Console.WriteLine("Virheellinen äänenvoimakkuuden arvo!");
        }
    }

    // Metodi taajuuden valitsemiseksi (kanavan valinta)
    public void VaihdaTaajuus(double taajuus, List<Kanava> kanavat)
    {
        if (taajuus >= 88.0 && taajuus <= 107.9)
        {
            Taajuus = taajuus;
            Console.WriteLine($"Taajuus on nyt: {Taajuus}");

            // Tarkistetaan, onko valittu taajuus jo olemassa olevien kanavien joukossa
            foreach (var kanava in kanavat)
            {
                if (kanava.Taajuus == Taajuus)
                {
                    Console.WriteLine($"Taajuus {Taajuus} vastaa kanavan {kanava.Nimi} taajuutta");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Virheellinen taajuuden arvo!");
        }
    }
}

class Kanava
{
    public string Nimi { get; set; }
    private double _taajuus;

    // Ominaisuus taajuudelle
    public double Taajuus
    {
        get { return _taajuus; }
        set
        {
            if (value >= 88.0 && value <= 107.9)
            {
                _taajuus = value;
            }
            else
            {
                Console.WriteLine("Virheellinen taajuuden arvo!");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Radio radio = new Radio();
        List<Kanava> kanavat = new List<Kanava>();

        // Luodaan kanavia ja lisätään ne listaan
        Kanava kanava1 = new Kanava { Nimi = "Kanava 1", Taajuus = 95.5 };
        Kanava kanava2 = new Kanava { Nimi = "Kanava 2", Taajuus = 100.0 };
        kanavat.Add(kanava1);
        kanavat.Add(kanava2);

        while (true)
        {
            Console.WriteLine("\nValitse toiminto:");
            Console.WriteLine("1 - Vaihda virta (Päälle/Pois)");
            Console.WriteLine("2 - Säädä äänenvoimakkuutta (0-9)");
            Console.WriteLine("3 - Vaihda taajuutta (88.0 - 107.9)");

            int valinta;
            if (int.TryParse(Console.ReadLine(), out valinta))
            {
                switch (valinta)
                {
                    case 1:
                        radio.VaihdaVirta();
                        break;
                    case 2:
                        Console.WriteLine("Syötä äänenvoimakkuus (0-9):");
                        if (int.TryParse(Console.ReadLine(), out int aanenvoimakkuus))
                        {
                            radio.SaataAanenvoimakkuus(aanenvoimakkuus);
                        }
                        else
                        {
                            Console.WriteLine("Virheellinen syöte!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Syötä taajuus (88.0 - 107.9):");
                        if (double.TryParse(Console.ReadLine(), out double taajuus))
                        {
                            radio.VaihdaTaajuus(taajuus, kanavat);
                        }
                        else
                        {
                            Console.WriteLine("Virheellinen syöte!");
                        }
                        break;
                    default:
                        Console.WriteLine("Valitse oikea numero (1-3)");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Virheellinen syöte!");
            }
        }
    }
}