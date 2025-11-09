using AbstractFactory.Armor.Chainmail;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class ChainmailArmory : IAbstractArmory
    {
        public IAbstractBreastPlate CreateBreastPlate()
        {
            return new ChainmailBreastPlate();
        }

        public IAbstractFootwear CreateFootwear()
        {
            return new ChainmailFootwear();
        }

        public IAbstractHelmet CreateHelmet()
        {
            return new ChainmailHelmet();
        }

        public IAbstractLegPlate CreateLegPlate()
        {
            return new ChainmailLegPlate();
        }
    }
}
