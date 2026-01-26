using SOLIDRefactor.Birds;
using SOLIDRefactor.Interfaces;

namespace SOLIDRefactor
{
    public class BirdProducer
    {
        public IBird? ProduceBird(string birdType)
        {
            if (birdType == "Pinguin")
            {
                return new Pinguin();
            }
            if (birdType == "Sparrow")
            {
                return new Sparrow();
            }
            return null;
        }


    }
}
