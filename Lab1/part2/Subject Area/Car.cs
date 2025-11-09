using part2.Subject_Area;
using Part2.Subject_Area.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2.Subject_Area
{
    public class Car : Vehicle
    {
        public WheelDrive WheelDrive { get; set; }
        public CarClass Class { get; set; }

        public string Color { get; set; }

        public override IPrototype GetClone()
        {
            return (Car)this.MemberwiseClone();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Whell drive - {this.WheelDrive.ToString()} Class - {this.Class.ToString()} Color - {this.Color}");
        }
    }
}
