using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.SubSystems
{
    public class ReloadingSubsystem
    {
        public void LoadShell(ShellTypes shellType)
        {
            Console.WriteLine($"{shellType.ToString()} shell primed");
        }
    }
}
