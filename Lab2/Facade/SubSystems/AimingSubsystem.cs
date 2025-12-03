using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SubSystems
{
    public class AimingSubsystem
    {
        public void AimOnTarget(int posX, int posY)
        {
            Console.WriteLine($"Guns locked to X:{posX} Y:{posY}");
        }

        public void SetRange(double range)
        {
            Console.WriteLine($"Range set on {range}");
        }
    }
}
