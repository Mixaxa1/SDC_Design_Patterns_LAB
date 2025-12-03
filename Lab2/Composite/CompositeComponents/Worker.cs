using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.CompositeComponents
{
    public class Worker : Employee
    {
        public override string FindOutWhoIsToBlame()
        {
            return "Why tf am i to blame?";
        }
    }
}
