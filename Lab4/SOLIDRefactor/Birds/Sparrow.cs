using SOLIDRefactor.BirdInterfaces;
using SOLIDRefactor.Interfaces;

namespace SOLIDRefactor.Birds
{
    internal class Sparrow : IBird, IDefendEgg, IDance, IFly, ISing, IWalk
    {
        public void DefendEgg()
        {
            Console.WriteLine("Hit the enemy");
        }
        public void Dance()
        {
            Console.WriteLine("Shake your body");
        }

        public void Fly()
        {
            Console.WriteLine("Spread the wings");
        }

        public void ProduceEgg()
        {
            Console.WriteLine("Some magic happens");
        }

        public void SearchForSpause()
        {
            Console.WriteLine("Time to search for the spause");
        }

        public void Sing()
        {
            Console.WriteLine("Some Iron Maiden song from 80-th");
        }

        public void Walk()
        {
            Console.WriteLine("Walk this way");
        }
    }
}
