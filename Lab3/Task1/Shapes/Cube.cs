using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Shapes
{
    public class Cube : IShape
    {
        public float Edge { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCube(this);
        }
    }
}
