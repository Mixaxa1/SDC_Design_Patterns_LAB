using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.ConcreteImplementation
{
    public class SparklyDices : IDiceKit
    {
        public Random _random { get; init; } = new Random();

        public string Name { get; init; } = "Sparkls";

        public int RollDNDice(int n)
        {
            Console.WriteLine("As dice hits the table sparks fly");
            return _random.Next(n - 1) + 1;
        }
    }
}
