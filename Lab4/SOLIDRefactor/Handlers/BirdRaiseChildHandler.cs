using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLIDRefactor.Interfaces;

namespace SOLIDRefactor.Handlers
{
    public class BirdRaiseChildHandler : IBirdActivityHandler
    {
        public void Handle(IBird bird)
        {
            bird.ProduceEgg();

            if (bird is IDefendEgg defending)
            {
                defending.DefendEgg();
            }
        }
    }
}
