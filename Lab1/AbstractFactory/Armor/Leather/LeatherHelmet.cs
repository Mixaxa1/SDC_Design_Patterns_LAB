using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Armor.Leather
{
    public class LeatherHelmet : IAbstractHelmet
    {
        public int Protection { get; set; } = 2;
        public string Name { get; set; } = "Шапка из дубленной кожи";
        public int VisionPenalty { get; set; } = 0;
    }
}
