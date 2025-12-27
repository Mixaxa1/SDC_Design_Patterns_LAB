
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Shapes
{
    public class Torus : IShape
    {
        public float CenterRadius { get; set; }
        public float RingRadius { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitTorus(this);
        }
    }
}
