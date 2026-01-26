using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidViolations.ISP_Violation
{
    public interface ITool
    {
        void TightenScrew();
        void Cut();
        void OpenCan();
        void SawWood();
    }
}
