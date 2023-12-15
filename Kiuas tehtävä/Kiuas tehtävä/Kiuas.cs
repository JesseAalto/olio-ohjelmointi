using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_3;
class Kiuas
{
    // Ominaisuudet
    private string Nimi;
    private int Lampotila;
    private int Kosteus;
    private bool Tila;

   
    public Kiuas(string nimi)
    {
        Nimi = nimi;
        Lampotila = 20; // Alustetaan lämpötila oletusarvona
        Kosteus = 50; // Alustetaan kosteus oletusarvona
        Tila = false; // Alustetaan kiukaan tila pois päältä
    }

    // Metodi kiukaan tietojen tulostamiseen
    public void TulostaTiedot()
    {
        Console.WriteLine("Kiuas: " + Nimi);
        Console.WriteLine("Lämpötila: " + Lampotila + " astetta");
        Console.WriteLine("Kosteus: " + Kosteus + "%");
        Console.WriteLine("Kiuas on " + (Tila ? "päällä" : "pois päältä"));
    }

    // Metodi lämpötilan muuttamiseen
    public void VaihdaLampotila(int uusiLampotila)
    {
        Lampotila = uusiLampotila;
    }

    // Metodi kosteuden muuttamiseen
    public void VaihdaKosteus(int uusiKosteus)
    {
        Kosteus = uusiKosteus;
    }

    // Metodi kiukaan tilan muuttamiseen (päälle/pois)
    public void VaihdaTila()
    {
        Tila = !Tila;
    }
}
