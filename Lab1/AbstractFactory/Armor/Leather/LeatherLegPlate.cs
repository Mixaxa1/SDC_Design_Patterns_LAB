using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Armor.Leather
{
    public class LeatherLegPlate : IAbstractLegPlate
    {
        public int Protection { get; set; } = 2;
        public string Name { get; set; } = "Дубленые штаны";
        public int SpeedPenalty { get; set; } = 1;
    }
}
