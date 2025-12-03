using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class NightClubEntrance : INightClubEntrance
    {
        public void Enter(string name)
        {
            Console.WriteLine($"{name} welcome to the club");
        }
    }
}
