using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Swift;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.ImprovedAbstractions
{
    public class Pathfinder : TTRPG
    {
        public Pathfinder(IDiceKit diceKit) : base(diceKit)
        {
        }

        public virtual void MakeSkillCheck(int difficulty, int skillLevel)
        {
            int rollDergee = 0;
            var result = diceKit.RollDNDice(20);
            Console.WriteLine($"Dice roll: {result}, check difficulty: {difficulty}, skill level: {skillLevel}");

            if (result == 20 )
            {
                rollDergee++;
            }
            else if (result == 1) {
                rollDergee--;
            }
            result += skillLevel;

            if (result >= difficulty + 10)
            {
                rollDergee++;
            }
            else if (result < difficulty - 10)
            {
                rollDergee--;
            }

            if (result < difficulty && rollDergee < 0)
            {
                Console.WriteLine($"Damn you {diceKit.Name}! Thats a critical failure!");
            }
            else if (result >= difficulty && rollDergee > 0)
            {
                Console.WriteLine($"Hell yeah! {diceKit.Name} my belowed, thats a crit success!");
            }
            else if (result >= difficulty || (result < difficulty && rollDergee > 0))
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
