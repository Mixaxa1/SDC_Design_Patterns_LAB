using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Armor.Chainmail
{
    public class ChainmailLegPlate : IAbstractLegPlate
    {
        public int Protection { get; set; }
        public string Name { get; set; } = "Кольчужные поножи";
        public int SpeedPenalty { get; set; } = 2;
    }
}
