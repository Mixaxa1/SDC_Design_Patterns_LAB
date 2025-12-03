using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IDiceKit
    {
        Random _random { get; init; }
        string Name { get; }

        public int RollDNDice(int n);
    }
}
