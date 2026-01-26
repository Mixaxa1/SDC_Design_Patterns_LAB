using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLIDRefactor.BirdInterfaces;
using SOLIDRefactor.Interfaces;

namespace SOLIDRefactor.Handlers
{
    public class BirdSearchForMateHandler : IBirdActivityHandler
    {
        public void Handle(IBird bird)
        {

            bird.SearchForSpause();

            if (bird is ISing singing)
            {
                singing.Sing();
            }
            if (bird is IDance dancing)
            {
                dancing.Dance();
            }
        }
    }
}
