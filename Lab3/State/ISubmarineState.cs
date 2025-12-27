using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public abstract class SubmarineStateBase
    {
        protected WWIISubmarine Submarine;

        public void SetSubmarine(WWIISubmarine submarine)
        {
            Submarine = submarine;
        }
        public abstract void MoveToTarget(int distanceToTarget);

        public abstract void FireTorpedoes();
    }
}
