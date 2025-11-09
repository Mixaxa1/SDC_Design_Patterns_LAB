using part2.Subject_Area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2.Subject_Area
{
    public class Tank : Vehicle
    {
        public int ProjectileCaliber {  get; set; }
        public float ShotsPerMinute { get; set; }
        public int CrewSize { get; set; }

        public override IPrototype GetClone()
        {
            return (Tank)this.MemberwiseClone();
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Projectile caliber {this.ProjectileCaliber} Shots per minute - {this.ShotsPerMinute} Crew size - {this.CrewSize}");
        }
    }
}
