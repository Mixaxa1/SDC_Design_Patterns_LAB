using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class WWIISubmarine
    {
        private SubmarineStateBase _state;

        public WWIISubmarine(SubmarineStateBase state)
        {
            TransitTo(state);
        }

        public void TransitTo(SubmarineStateBase state)
        {
            Console.WriteLine($"\nTransition to {state.GetType().Name}");
            _state = state;
            _state.SetSubmarine(this);
        }

        public void FireTorpedoes()
        {
            _state.FireTorpedoes();
        }

        public void MoveToTarget(int distance)
        {
            _state.MoveToTarget(distance);
        }
    }
}
