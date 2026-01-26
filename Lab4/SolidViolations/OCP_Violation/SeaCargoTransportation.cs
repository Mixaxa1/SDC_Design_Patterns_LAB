using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.OCP_Violation
{
    //
    public class SeaCargoTransportation
    {
        public void Transport(CargoType cargoType)
        {
            if (cargoType == CargoType.Small)
            {
                Console.WriteLine("Humble boat should do");
            }
            else if (cargoType == CargoType.Medium)
            {
                Console.WriteLine("It will go on a barge");
            }
            else if (cargoType == CargoType.Large)
            {
                Console.WriteLine("It has to wait for a container ship");
            }
        }
    }

    public enum CargoType
    {
        Small, Medium, Large
    }
}
