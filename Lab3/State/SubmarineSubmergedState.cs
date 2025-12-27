using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SubmarineSubmergedState : SubmarineStateBase
    {
        public int speed = 8;

        public override void FireTorpedoes()
        {
            Console.WriteLine("Emerging in order to fire");
            Console.WriteLine("Pump station - drain balasts! Weapon stating prepare to fire");

            Submarine.TransitTo(new SubmarineEmergedState());
            Submarine.FireTorpedoes();
        }

        public override void MoveToTarget(int distanceToTarget)
        {
            Console.WriteLine("Electric engine primed, moving to target");

            var turns = 0;
            while (distanceToTarget > 0)
            {
                turns++;
                distanceToTarget -= speed;

                Console.WriteLine($"Turn {turns} of moving to target");
            }

            Console.WriteLine("Arrived at the fiering distance\n");
        }
    }
}
