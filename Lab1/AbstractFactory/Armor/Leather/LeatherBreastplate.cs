using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Armor.Leather
{
    public class LeatherBreastplate : IAbstractBreastPlate
    {
        public int Protection { get; set; } = 3;
        public string Name { get; set; } = "Нагрудник из дубленой кожи";
        public int DexPenalty { get; set; } = 1;
    }
}
