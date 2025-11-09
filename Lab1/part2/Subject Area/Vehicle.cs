using Part2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2.Subject_Area
{
    public class Vehicle : IPrototype
    {
        public float Weight { get; set; }
        public float Lenght { get; set; }
        public int MaxSpeed { get; set; }
        public string Name { get; set; } = string.Empty;

        public virtual IPrototype GetClone()
        {
            return (Vehicle)this.MemberwiseClone();
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{this.GetType()}\nName - {this.Name} Weight - {this.Weight} Lenght - {this.Lenght} Max speed - {this.MaxSpeed}");
        }
    }
}