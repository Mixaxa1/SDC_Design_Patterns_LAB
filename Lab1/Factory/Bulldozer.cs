using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Bulldozer : IExcavationVehicle
    {
        public void Excavate()
        {
            Console.WriteLine("Опустить отвал \n Зачерпнуть землю \n Сгрузить в сброс\n");
        }
    }
}
