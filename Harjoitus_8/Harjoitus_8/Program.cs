using System;

// Henkilö luokka
public class Henkilo
{
    // Ominaisuudet
    public string Nimi { get; set; }
    public string Tyopaikka { get; set; }
    public double Palkka { get; set; }
}

// Työntekijä-luokka, joka perii Henkilö-luokan
class Tyontekija : Henkilo
{
    // Työntekijän viikottaiset tunnit
    public int ViikottaisetTunnit { get; set; }
}

// Pomo-luokka, joka perii Henkilö-luokan
class Pomo : Henkilo
{
    // Ominaisuudet johtajan bonukselle ja autolle
    public double Bonus { get; set; }
    public string Auto { get; set; }
}

// Pääohjelma
class Program
{
    static void Main()
    {
        // Luodaan Työntekijä-olio
        Tyontekija tyontekija = new Tyontekija
        {
            Nimi = "Matti Menninkäinen",
            Tyopaikka = "Koodari Oy",
            Palkka = 2500,
            ViikottaisetTunnit = 40
        };

        // Luodaan Pomo-olio
        Pomo pomo = new Pomo
        {
            Nimi = "Johtaja Jari",
            Tyopaikka = "Koodari Oy",
            Palkka = 5000,
            Bonus = 1500,
            Auto = "Mersu"
        };

        Console.WriteLine("Työntekijä:");
        Console.WriteLine($"Nimi: {tyontekija.Nimi}");
        Console.WriteLine($"Työpaikka: {tyontekija.Tyopaikka}");
        Console.WriteLine($"Palkka: {tyontekija.Palkka} euroa/kk");
        Console.WriteLine($"Viikottaiset tunnit: {tyontekija.ViikottaisetTunnit} h\n");

        Console.WriteLine("Pomo:");
        Console.WriteLine($"Nimi: {pomo.Nimi}");
        Console.WriteLine($"Työpaikka: {pomo.Tyopaikka}");
        Console.WriteLine($"Palkka: {pomo.Palkka} euroa/kk");
        Console.WriteLine($"Bonus: {pomo.Bonus} euroa");
        Console.WriteLine($"Auto: {pomo.Auto}");

        Console.ReadLine();
    }
}