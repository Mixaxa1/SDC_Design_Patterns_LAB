using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TTRPGPlayerClient
    {
        public void AskToMakeSkillCheck(TTRPG system, int difficulty, int skillLevel)
        {
            Console.WriteLine("Player attemts to make a skill check");
            system.MakeSkillCheck(difficulty, skillLevel);
        }
    }
}
