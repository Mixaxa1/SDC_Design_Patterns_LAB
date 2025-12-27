using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Shapes
{
    public class Sphere : IShape
    {
        public float Radius { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitSphere(this);
        }
    }
}
