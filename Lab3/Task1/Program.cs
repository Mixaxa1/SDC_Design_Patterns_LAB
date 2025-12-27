using System.ComponentModel;
using Task1;
using Task1.Shapes;

List<IShape> shapes = new List<IShape>
{
    new Cube { Edge = 3.4f },
    new Sphere { Radius = 10 },
    new StraightParallelepiped { Edge1 = 3, Edge2 = 4, Edge3 = 5 },
    new Torus { CenterRadius = 10 , RingRadius = 3 },
};

var visitor = new VolumeCalculationVisitor();

foreach (var shape in shapes)
{
    shape.Accept(visitor);
}