using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AmericanTouristMetricMapAdapter : IAmericanTouristClient
    {
        private readonly MetricMap _map;

        public AmericanTouristMetricMapAdapter(MetricMap map)
        {
            _map = map;
        }

        public void MoveInMiles()
        {
            var directions = _map.GetDirectionsInKM();

            var directionsInMies = directions * 0.62;

            Console.WriteLine($"American tourist moved {directionsInMies} miles");
        }
    }
}
