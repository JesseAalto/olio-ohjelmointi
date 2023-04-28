using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
public class Case
{
    private string name;
    private int rarity;
    private Random random;

    public Case(string name, int rarity)
    {
        this.name = name;
        this.rarity = rarity;
        random = new Random();
    }

    public void Open()
    {
        Console.WriteLine($"Opening {name} case...");

        int result = random.Next(100); // arvotaan satunnainen luku välillä 0-99

        if (result < 5)
        {
            Console.WriteLine("Congratulations! You got a rare knife!");
        }
        else if (result < 20)
        {
            Console.WriteLine("You got a rare weapon skin!");
        }
        else if (result < 60)
        {
            Console.WriteLine("You got an uncommon weapon skin.");
        }
        else
        {
            Console.WriteLine("You got a common weapon skin.");
        }
    }
}





