using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Excavator : IExcavationVehicle
    {
        public void Excavate()
        {
            Console.WriteLine("Опустить стрелу \n Опустить рукоять \n Зачерпнуть землю ковшом \n Повернуться и сгрузить в сброс \n");
        }
    }
}
