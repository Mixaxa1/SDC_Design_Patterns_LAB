using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.LSP_Violation
{
    public class ResearchLab
    {
        public CalculatingUint calcUnit {  get; set; }

        public void DoResearch()
        {
            calcUnit.MakeCalculation(2, 5);

            Console.WriteLine("Research complete");
        }
    }
}
