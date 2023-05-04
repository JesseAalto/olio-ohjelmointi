using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_10
{
    class Sorsa : Eläin, ICanSwim, ICanFly
    {
        public int SwimSpeed { get; set; }
        public float WingSize { get; set; }

        public Sorsa(string _name, float _wingSize, int _speed)
        {
            Name = _name;
            WingSize = _wingSize;
            SwimSpeed = _speed;
        }

        public void Fly()
        {
            Console.WriteLine("{0} lentää. Siipien koko on {1}", Name, WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("quack");
        }

        public void Swim()
        {
            Console.WriteLine("{0} ui nopeudella {1}", Name, SwimSpeed);
        }
    }
}
