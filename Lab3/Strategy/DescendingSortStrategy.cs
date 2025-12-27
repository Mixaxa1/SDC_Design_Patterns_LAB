using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DescendingSortStrategy : IIntSortStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Sorting list in descending order");

            return list.OrderByDescending(x => x).ToList();
        }
    }
}
