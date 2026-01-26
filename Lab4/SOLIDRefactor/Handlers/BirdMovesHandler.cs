using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLIDRefactor.Interfaces;

namespace SOLIDRefactor.Handlers
{
    public class BirdMovesHandler : IBirdActivityHandler
    {
        public void Handle(IBird bird)
        {
            if (bird is IWalk walking)
            {
                walking.Walk();
            }
            if (bird is IFly flying)
            {
                flying.Fly();
            }
        }
    }
}
