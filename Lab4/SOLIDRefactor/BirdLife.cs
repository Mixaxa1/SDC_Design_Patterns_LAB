using SOLIDRefactor.Birds;
using SOLIDRefactor.Handlers;
using SOLIDRefactor.Interfaces;

namespace SOLIDRefactor
{
    internal class BirdLife
    {
        private List<IBirdActivityHandler> _birdRoutine = new List<IBirdActivityHandler>();

        public void SetBirdRoutine(List<IBirdActivityHandler> birdRoutine)
        {
            _birdRoutine = birdRoutine;
        }

        public void DoBirdActions(IBird bird)
        {
            foreach (var action in _birdRoutine)
            {
                action.Handle(bird);
            }
        }
    }
}
