using part2.Subject_Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2.Subject_Area
{
    public class Cargo : Vehicle
    {
        public int Tonnage { get; set; }
        public int TankVolume { get; set; }
        public int AxelsAmount { get; set; }

        public override IPrototype GetClone()
        {
            return (Cargo)this.MemberwiseClone();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Tonnage - {this.Tonnage} Tanl volume - {this.TankVolume} Axels amount - {this.AxelsAmount}");
        }
    }
}
