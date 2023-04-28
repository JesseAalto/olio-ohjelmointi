// Pääohjelma
public class Ohjelma
{
    static void Main()
    {
        Case case1 = new Case("Winter Offensive Weapon Case", 3);
        Case case2 = new Case("Chroma 2 Case", 2);

        case1.Open();
        case2.Open();
    }
}