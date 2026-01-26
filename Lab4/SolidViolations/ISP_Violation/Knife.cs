using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.ISP_Violation
{
    public class Knife : ITool
    {
        public void Cut()
        {
            Console.WriteLine("In half!");
        }

        public void OpenCan()
        {
            Console.WriteLine("Done but it took quite effort");
        }

        public void SawWood()
        {
            Console.WriteLine("I cant do that!");
        }

        public void TightenScrew()
        {
            Console.WriteLine("I cant do that!");
        }
    }
}
