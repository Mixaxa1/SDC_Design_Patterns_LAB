using Task1.Shapes;

namespace Task1
{
    public class VolumeCalculationVisitor : IVisitor
    {
        public void VisitCube(Cube cube)
        {
            Console.WriteLine($"Cube volume: {Math.Pow(cube.Edge, 3)}");
        }

        public void VisitParallelepiped(StraightParallelepiped parallelepiped)
        {
            Console.WriteLine($"Parallelepiped volume: {parallelepiped.Edge1 * parallelepiped.Edge2 * parallelepiped.Edge3}");
        }

        public void VisitSphere(Sphere sphere)
        {
            Console.WriteLine($"Sphere volume: {(4 / 3) * Math.PI * Math.Pow(sphere.Radius, 3)}");
        }

        public void VisitTorus(Torus torus)
        {
            Console.WriteLine($"Torus volume: {2 * Math.Pow(Math.PI, 2) * torus.CenterRadius * Math.Pow(torus.RingRadius, 2)}");
        }
    }
}
