using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DivineSortStrategy : IIntSortStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Lets assume that list is already sorted by divine intervention");

            Console.WriteLine("Any evidence to contrarty is heretical");

            return list;
        }
    }
}
