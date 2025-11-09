using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Client
    {
        private IAbstractArmory armory;

        public Client(IAbstractArmory armory)
        {
            this.armory = armory;
        }

        public void CheckArmor()
        {
            var helmet = armory.CreateHelmet();
            var breastPlate = armory.CreateBreastPlate();
            var legPlate = armory.CreateLegPlate();
            var footwear = armory.CreateFootwear();

            Console.WriteLine($"{helmet.Name} \n{breastPlate.Name} \n{legPlate.Name} \n{footwear.Name}");
        }
    }
}
