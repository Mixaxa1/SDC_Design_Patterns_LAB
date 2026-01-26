using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOLIDRefactor.Interfaces;

namespace SOLIDRefactor.Handlers
{
    public interface IBirdActivityHandler
    {
        void Handle(IBird bird);
    }
}
