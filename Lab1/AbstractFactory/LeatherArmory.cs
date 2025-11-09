using AbstractFactory.Armor.Leather;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class LeatherArmory : IAbstractArmory
    {
        public IAbstractBreastPlate CreateBreastPlate()
        {
            return new LeatherBreastplate();
        }

        public IAbstractFootwear CreateFootwear()
        {
            return new LeatherFootwear();
        }

        public IAbstractHelmet CreateHelmet()
        {
            return new LeatherHelmet();
        }

        public IAbstractLegPlate CreateLegPlate()
        {
            return new LeatherLegPlate();
        }
    }
}
