using part2.Subject_Area;
using Part2.Subject_Area;
using Part2.Subject_Area.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public sealed class PrototypeRegistry
    {
        private static PrototypeRegistry _instance;
        private static readonly object _lock = new object();
        private static List<IPrototype> _prototypes = new List<IPrototype>();

        public static PrototypeRegistry GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PrototypeRegistry();
                        _instance.InitializePrototypes();
                    }
                }
            }
            return _instance;
        }

        public void InitializePrototypes()
        {
            _prototypes.Add(new Vehicle { Name = "Mother of all", MaxSpeed = 42, Lenght = 42, Weight = 42 });
            _prototypes.Add(new Car { Name = "BaseCar", Weight = 1000, Lenght = 5, MaxSpeed = 40, Class = CarClass.couple, Color = "Black" });
            _prototypes.Add(new Car { Name = "Honda Civic", Weight = 1000, Lenght = 10, MaxSpeed = 120, Class = CarClass.sedan, Color = "Red" });
            _prototypes.Add(new Cargo { Name = "CargoBase", Weight = 4000, Lenght = 12, MaxSpeed = 60, AxelsAmount = 2, TankVolume = 200, Tonnage = 50 });
            _prototypes.Add(new Tank { Name = "FT-17", Weight = 2000, Lenght = 5, MaxSpeed = 12, CrewSize = 2, ProjectileCaliber = 50, ShotsPerMinute = 5});
            _prototypes.Add(new Tank { Name = "T-34", Weight = 26000, Lenght = 6, MaxSpeed = 53, CrewSize = 4, ProjectileCaliber = 75, ShotsPerMinute = 8 });
        }

        public IPrototype? GetPrototypeByIndex(int index)
        {
            return _prototypes[index];
        }

        public int GetRegistyCount()
        {
            return _prototypes.Count;
        }

        public void ShowPrototypesInfo()
        {
            for (int i = 0; i < _prototypes.Count; i++)
            {
                Console.WriteLine($"Index {i}");
                _prototypes[i].ShowInfo();
            }
        }
    }
}
