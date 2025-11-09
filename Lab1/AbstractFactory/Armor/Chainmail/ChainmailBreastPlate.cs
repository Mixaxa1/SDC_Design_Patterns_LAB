using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Armor.Chainmail
{
    public class ChainmailBreastPlate : IAbstractBreastPlate
    {
        public int Protection { get; set; } = 5;
        public string Name { get; set; } = "Кольчужная рубаха";
        public int DexPenalty { get; set; } = 2;
    }
}
