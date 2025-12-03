using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SubSystems
{
    public class RangefinderSubsystem
    {
        public double GetRangeToTarget(Ship target, Ship self)
        {
            return Math.Sqrt(Math.Pow(self.XPos - target.XPos, 2) + Math.Pow(self.YPos - target.YPos, 2));
        }
    }
}
