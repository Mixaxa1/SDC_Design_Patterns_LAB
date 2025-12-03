using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class FaceControlProxy : INightClubEntrance
    {
        private readonly INightClubEntrance _entrance;
        private readonly List<string> _whiteList;

        public FaceControlProxy(INightClubEntrance entrance, List<string> whiteList)
        {
            _entrance = entrance;

            _whiteList = whiteList;
        }

        public void Enter(string name)
        {
            if (_whiteList.Contains(name))
            {
                _entrance.Enter(name);
            }
            else
            {
                Console.WriteLine($"This is a club for members only {name}");
            }
        }
    }
}
