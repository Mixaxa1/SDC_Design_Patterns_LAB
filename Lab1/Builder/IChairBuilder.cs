using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IChairBuilder
    {
        void AddLegs();
        void AddSeat();
        void AddBack();
    }
}
