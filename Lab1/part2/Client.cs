using part2.Subject_Area;
using Part2.Subject_Area;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class Client
    {
        private List<IPrototype> _objects = new List<IPrototype>();
        private PrototypeRegistry _register = PrototypeRegistry.GetInstance();

        public void Start()
        {
            _objects.Add(_register.GetPrototypeByIndex(4));

            string input = string.Empty;

            while (true)
            {
                Console.WriteLine("Options:\n1 - Create new object\n2 - Show objects list\n3 - Delete object\n0 - Exit\n");
                input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }
                else if (input == "1")
                {
                    CreateNewObjectDialog();
                }
                else if (input == "2") 
                {
                    ShowInfoDialog();
                }
                else if (input == "3")
                {
                    DeleteObjectDialog();
                }
                else
                {
                    Console.WriteLine("Incorrect input, try again");
                }
               
            }
        }
        public void CreateNewObjectDialog()
        {

            Console.WriteLine($"Select index of prototype you want to use for new object");
            _register.ShowPrototypesInfo();

            var valid = int.TryParse(Console.ReadLine(), out int prototypeInd);
            if (!valid || (prototypeInd < 0 && prototypeInd > _register.GetRegistyCount()))
            {
                Console.WriteLine("Invalid input, operation abort");
                return;
            }

            var prototype = _register.GetPrototypeByIndex(prototypeInd);
            Console.WriteLine("Edit prototype? y//n");
            if (Console.ReadLine() != "y")
            {
                _objects.Add(prototype);
                return;
            }

            Console.WriteLine("If you wish to keep default value of field, just push ENTER");

            Console.WriteLine("Enter new name (str)");
            var input = Console.ReadLine();
            if (input != string.Empty)
            {
                prototype.Name = input;
            }

            Vehicle prototypeVehicle = (Vehicle)prototype;
            Console.WriteLine("Enter new lenght (float)");
            input = Console.ReadLine();
            if (input != string.Empty)
            {
                prototypeVehicle.Lenght = float.Parse(input);
            }

            Console.WriteLine("Enter new weight (float)");
            input = Console.ReadLine();
            if (input != string.Empty)
            {
                prototypeVehicle.Weight = float.Parse(input);
            }

            Console.WriteLine("Enter new max speed (int)");
            input = Console.ReadLine();
            if (input != string.Empty)
            {
                prototypeVehicle.MaxSpeed = int.Parse(input);
            }

            if (prototype.GetType() == typeof(Car))
            {
                Car prototypeCar = (Car)prototype;

                Console.WriteLine("Enter new color (str)");
                input = Console.ReadLine();
                if (input != string.Empty)
                {
                    prototypeCar.Color = input;
                }

                prototype = prototypeCar;
            }
            else if (prototype.GetType() == typeof(Cargo))
            {
                Cargo prototypeCargo = (Cargo)prototype;

                Console.WriteLine("Enter new tonnage (int)");
                input = Console.ReadLine();
                if (input != string.Empty)
                {
                    prototypeCargo.Tonnage = int.Parse(input);
                }
                Console.WriteLine("Enter new tank volume (int)");
                input = Console.ReadLine();
                if (input != string.Empty)
                {
                    prototypeCargo.TankVolume = int.Parse(input);
                }
                Console.WriteLine("Enter new axels amount (int)");
                input = Console.ReadLine();
                if (input != string.Empty)
                {
                    prototypeCargo.AxelsAmount = int.Parse(input);
                }

                prototype = prototypeCargo;
            }
            else if (prototype.GetType() == typeof(Tank))
            {
                Tank prototypeTank = (Tank)prototype;

                Console.WriteLine("Enter new gun caliber (int)");
                input = Console.ReadLine();
                if (input != string.Empty)
                {
                    prototypeTank.ProjectileCaliber = int.Parse(input);
                }
                Console.WriteLine("Enter new crew size (int)");
                input = Console.ReadLine();
                if (input != string.Empty)
                {
                    prototypeTank.CrewSize = int.Parse(input);
                }
                Console.WriteLine("Enter new shots per minute (float)");
                input = Console.ReadLine();
                if (input != string.Empty)
                {
                    prototypeTank.ShotsPerMinute = float.Parse(input);
                }

                prototype = prototypeTank;
            }

            _objects.Add(prototype);
        }

        public void ShowInfoDialog()
        {
            for (int i = 0; i < _objects.Count; i++)
            {
                Console.WriteLine($"Index {i}");
                _objects[i].ShowInfo();
            }
        }

        public void DeleteObjectDialog()
        {
            Console.WriteLine("Choose index of the object you want to delete");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                _objects.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Incorrect input, try again");
            }
        }
    }
}
