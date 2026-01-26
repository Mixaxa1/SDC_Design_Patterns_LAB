using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.ISP_Violation
{
    public class Saw : ITool
    {
        public void Cut()
        {
            Console.WriteLine("Done, but now its a mess!");
        }

        public void OpenCan()
        {
            Console.WriteLine("I cant do that!");
        }

        public void SawWood()
        {
            Console.WriteLine("Only saw dust around");
        }

        public void TightenScrew()
        {
            Console.WriteLine("I cant do that!");
        }
    }
}
