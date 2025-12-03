using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.CompositeComponents;

namespace Composite
{
    public class VeryEfficientCompanyClient
    {
        public void FigureOutWhoMadeMisstake(Employee employee)
        {
            Console.WriteLine(employee.FindOutWhoIsToBlame());
        }
    }
}
