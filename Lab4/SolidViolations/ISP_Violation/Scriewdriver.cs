using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.ISP_Violation
{
    public class Scriewdriver : ITool
    {
        public void Cut()
        {
            Console.WriteLine("I cant do that!");
        }

        public void OpenCan()
        {
            Console.WriteLine("I cant do that!");
        }

        public void SawWood()
        {
            Console.WriteLine("I cant do that!");
        }

        public void TightenScrew()
        {
            Console.WriteLine("Now sits tightly");
        }
    }
}
