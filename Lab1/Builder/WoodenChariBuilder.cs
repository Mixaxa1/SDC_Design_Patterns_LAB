using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class WoodenChariBuilder : IChairBuilder
    {
        private Chair _chair = new Chair();

        public WoodenChariBuilder()
        {
            _chair = new Chair();
        }

        public void Reset()
        {
            _chair = new Chair();
        }

        public void AddBack()
        {
            _chair.BackMaterial = "Дерево";
        }

        public void AddLegs()
        {
            _chair.LegsMaterial = "Дерево";
        }

        public void AddSeat()
        {
            _chair.SeatMaterial = "Дерево";
        }

        public Chair GetChair()
        {
            var result = _chair;
            this.Reset();

            return result;
        }
    }
}
