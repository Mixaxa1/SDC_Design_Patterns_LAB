using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.ImprovedAbstractions
{
    public class DarkHeresy : TTRPG
    {
        public DarkHeresy(IDiceKit diceKit) : base(diceKit)
        {
        }

        public override void MakeSkillCheck(int difficulty, int skillLevel)
        {
            var result = diceKit.RollDNDice(100);
            Console.WriteLine($"Dice roll: {result}, check difficulty: {difficulty}, skill level: {skillLevel}");

            if (result >= 96)
            {
                Console.WriteLine($"Damn you {diceKit.Name}! Thats a critical failure!");
            }
            else if (result <= 5)
            {
                Console.WriteLine($"Hell yeah! {diceKit.Name} my belowed, thats a crit success!");
            }
            else if (result <= skillLevel + difficulty)
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
