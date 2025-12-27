using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class SubmarineEmergedState : SubmarineStateBase
    {
        public int speed = 12;

        public override void FireTorpedoes()
        {
            Console.WriteLine("Torpedoes fired!");
        }

        public override void MoveToTarget(int distanceToTarget)
        {
            Console.WriteLine("\nSubmerging a little to leave periscope, exhaust and air pipe above water");
            Console.WriteLine("Disel engine primed, moving to target");

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
