using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.DIP_Violation
{
    public class FootPathBuilder
    {
        public Path BuildPath((int, int) start, (int, int) end)
        {
            return new Path() { startPoint = start, endPoint = end, Instructions = "Some instructions" };
        }
    }
}
