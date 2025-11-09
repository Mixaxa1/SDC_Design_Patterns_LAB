using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Armor.Chainmail
{
    public class ChainmailHelmet : IAbstractHelmet
    {
        public int Protection { get; set; } = 3;
        public string Name { get; set; } = "Койф";
        public int VisionPenalty { get; set; } = 1;
    }
}
