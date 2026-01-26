using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.LSP_Violation
{
    public class FancyCalculatingUint : CalculatingUint
    {
        private bool isCalibrated = false;
        public override int MakeCalculation(int num1, int num2)
        {
            if (isCalibrated)
            {
                return base.MakeCalculation(num1, num2);
            }
            else
            {
                throw new Exception("But new fancy calculating uint need to be calibrated!!!1!11!!!");
            }
        }

        public void Calibrate()
        {
            isCalibrated = true;
        }
    }
}
