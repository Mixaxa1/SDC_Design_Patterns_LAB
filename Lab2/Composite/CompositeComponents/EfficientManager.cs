using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.CompositeComponents
{
    public class EfficientManager : Employee
    {
        protected List<Employee> _subordinates = new List<Employee>();

        public override string FindOutWhoIsToBlame()
        {
            int i = 0;
            string result = "I cant be at blame! It must be one of my subordinates!\n(";
            foreach (Employee e in _subordinates)
            {
                result += e.FindOutWhoIsToBlame();

                if (i != _subordinates.Count - 1)
                {
                    result += "+\n";
                }
                i++;
            }

            return result + ")";
        }

        public override void Add(Employee employee)
        {
            _subordinates.Add(employee);
        }

        public override void Remove(Employee employee)
        {
            _subordinates.Remove(employee);
        }

        public override bool IsComposite()
        {
            return true;
        }
    }
}
