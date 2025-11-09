using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Armor.Chainmail
{
    public class ChainmailFootwear : IAbstractFootwear
    {
        public int Protection { get; set; } = 2;
        public string Name { get; set; } = "Кольчужныее сапоги";
        public int StealthPenalty { get; set; } = 4;
    }
}
