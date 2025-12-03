using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TTRPG
    {
        protected IDiceKit diceKit;

        public TTRPG(IDiceKit diceKit)
        {
            this.diceKit = diceKit;
        }

        public virtual void MakeSkillCheck(int difficulty, int skillLevel)
        {
            var result = diceKit.RollDNDice(20);
            Console.WriteLine($"Dice roll: {result}, check difficulty: {difficulty}, skill level: {skillLevel}");
            if (result == 1)
            {
                Console.WriteLine($"Damn you {diceKit.Name}! Thats a critical failure!");
            }
            else if (result == 20)
            {
                Console.WriteLine($"Hell yeah! {diceKit.Name} my belowed, thats a crit success!");
            }

            result += skillLevel;

            if (result - difficulty >= 0)
            {
                Console.WriteLine("Nice, a success");
            }
            else
            {
                Console.WriteLine("Oh, thats a failure");
            }
        }
    }
}
