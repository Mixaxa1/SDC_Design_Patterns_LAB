using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.LSP_Violation
{
    public class CalculatingUint
    {
        public virtual int MakeCalculation(int num1, int num2)
        {
            return num1 * num2 + (num2 - num1);
        }
    }
}
