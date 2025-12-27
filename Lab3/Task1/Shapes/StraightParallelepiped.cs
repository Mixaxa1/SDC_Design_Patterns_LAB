using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Shapes
{
    public class StraightParallelepiped : IShape
    {
        public float Edge1 { get; set; }
        public float Edge2 { get; set; }
        public float Edge3 { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitParallelepiped(this);
        }
    }
}
