using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class EnemyFlyweight
    {
        private readonly Random _random = new Random();

        public string Name;
        public string Model;
        public List<string> Sounds;


        public void Attack()
        {
            MakeSound();
        }

        public void GetHit()
        {
            MakeSound();
        }

        public void MakeSound()
        {
            Console.WriteLine(Name + ": " + Sounds[_random.Next(Sounds.Count)] + "\n");

        }
    }
}
