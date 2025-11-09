using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public interface IPrototype
    {
        public string Name { get; set; }
        IPrototype GetClone();

        void ShowInfo();
    }
}
