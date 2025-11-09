using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IAbstractLegPlate
    {
        public abstract int Protection { get; set; }
        public abstract string Name { get; set; }
        public abstract int SpeedPenalty { get; set; }
    }
}
