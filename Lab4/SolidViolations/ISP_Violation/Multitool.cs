using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.ISP_Violation
{
    public class Multitool : ITool
    {
        public void Cut()
        {
            Console.WriteLine("In half!");
        }

        public void OpenCan()
        {
            Console.WriteLine("Like god turtle");
        }

        public void SawWood()
        {
            Console.WriteLine("Only saw dust around");
        }

        public void TightenScrew()
        {
            Console.WriteLine("Now sits tightly");
        }
    }
}
