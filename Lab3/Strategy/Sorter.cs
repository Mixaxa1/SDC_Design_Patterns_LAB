using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Sorter
    {
        private IIntSortStrategy _strategy;

        public Sorter(IIntSortStrategy sortStrategy)
        {
            _strategy = sortStrategy;
        }

        public void SetStrategy(IIntSortStrategy strategy)
        {
            _strategy = strategy;
        }

        public List<int> Sort(List<int> list)
        {
            Console.WriteLine();
            Console.WriteLine("Lets sort some numbers!");

            Console.WriteLine("Numbers is:");

            foreach (int item in list) Console.WriteLine(item);

            list = _strategy.Sort(list);

            Console.WriteLine("After sort:");

            foreach (int item in list) Console.WriteLine(item);
            Console.WriteLine();

            return list;
        }
    }
}
