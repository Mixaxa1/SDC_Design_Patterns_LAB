using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Armor.Leather
{
    public class LeatherFootwear : IAbstractFootwear

    {
        public int Protection { get; set; } = 1;
        public string Name { get; set; } = "Дубленые сапоги";
        public int StealthPenalty { get; set; } = 0;
    }
}
