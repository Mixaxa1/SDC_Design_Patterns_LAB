using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.DIP_Violation
{
    public class MapNavigator
    {
        public FootPathBuilder pathBuiler { get; set; }

        public void BuildAndDisplayPath((int, int) start, (int, int) end)
        {
            var path = pathBuiler.BuildPath(start, end);

            Console.WriteLine($"You are going from {path.startPoint} to {path.endPoint}\nHere instructions:\n{path.Instructions}");
        }
    }
}
