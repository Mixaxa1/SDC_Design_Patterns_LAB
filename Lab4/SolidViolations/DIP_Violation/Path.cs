using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.DIP_Violation
{
    public class Path
    {
        public (int, int) startPoint { get; set; }
        public (int, int) endPoint { get; set; }
        public string Instructions { get; set; }
    }
}
