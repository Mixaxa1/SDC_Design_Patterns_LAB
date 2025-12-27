using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class AscendingSortStrategy : IIntSortStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("Sorting list in ascending order");

            return list.OrderBy(x => x).ToList();
        }
    }
}
