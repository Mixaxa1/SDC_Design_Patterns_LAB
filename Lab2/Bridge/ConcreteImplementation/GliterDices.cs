using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.ConcreteImplementation
{
    public class GliterDices : IDiceKit
    {
        public Random _random { get; init; } = new Random();

        public string Name { get; init; } = "Prophets of glittery doom";

        public int RollDNDice(int n)
        {
            Console.WriteLine("Congratulations!!! Now all the table and everything and everyone around covered in glitter!");
            return _random.Next(n - 1) + 1;
        }
    }
}
