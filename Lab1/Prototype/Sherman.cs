using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Sherman : IPrototype
    {
        public string Name { get; set; }
        public int CrewSize { get; set; }
        public int GunCaliber { get; set; }

    public void ShowInfo()
        {
            Console.WriteLine($"Хэш {this.GetHashCode()} Имя {Name} Размер экипажа {CrewSize} Калибр орудия {GunCaliber}");
        }

    public IPrototype GetClone()
        {
            return (Sherman)this.MemberwiseClone();
        }
    }
}
