using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Chair
    {
        public string LegsMaterial { get; set; } = string.Empty;
        public string BackMaterial { get; set; } = string.Empty;
        public string SeatMaterial { get; set; } = string.Empty;

        public void ShowInfo()
        {
            var legs = LegsMaterial == string.Empty ? "нету" : LegsMaterial;
            var back = BackMaterial == string.Empty ? "нету" : BackMaterial;
            var seat = SeatMaterial == string.Empty ? "нету" : SeatMaterial;
            Console.WriteLine($"Ножки {legs} Спинка {back} Сидушка {seat}");
        }
    }
}
