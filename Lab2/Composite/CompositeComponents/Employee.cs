using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.CompositeComponents
{
    public abstract class Employee
    {
        public abstract string FindOutWhoIsToBlame();

        public virtual void Add(Employee employee)
        {
        }

        public virtual void Remove(Employee employee)
        {
        }

        public virtual bool IsComposite()
        {
            return false;
        }
    }
}
