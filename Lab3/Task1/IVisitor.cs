using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Shapes;

namespace Task1
{
    public interface IVisitor
    {
        void VisitCube(Cube component);
        void VisitSphere(Sphere sphere);
        void VisitParallelepiped(StraightParallelepiped parallelepiped);
        void VisitTorus(Torus torus);
    }
}
