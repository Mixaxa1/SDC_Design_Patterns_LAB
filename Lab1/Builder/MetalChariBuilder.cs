using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class MetalChariBuilder : IChairBuilder
    {
        private Chair _chair = new Chair();

        public MetalChariBuilder()
        {
            _chair = new Chair();
        }

        public void Reset()
        {
            _chair = new Chair();
        }

        public void AddBack()
        {
            _chair.BackMaterial = "Железо";
        }

        public void AddLegs()
        {
            _chair.LegsMaterial = "Железо";
        }

        public void AddSeat()
        {
            _chair.SeatMaterial = "Железо";
        }

        public Chair GetChair()
        {
            var result = _chair;
            this.Reset();

            return result;
        }
    }
}
