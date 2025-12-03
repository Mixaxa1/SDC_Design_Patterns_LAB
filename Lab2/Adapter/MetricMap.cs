using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MetricMap
    {
        private readonly Random random = new Random();

        public int GetDirectionsInKM()
        {
            var directions = random.Next(1, 10);
            Console.WriteLine($"Directions given: move {directions} km");
            return directions;
        }
    }
}
