using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class CommandDeckClient
    {
        public void OrderEngageTarget(FireControllFacade ShipSystem, Ship target)
        {
            ShipSystem.EngageTarget(target);
        }
    }
}
