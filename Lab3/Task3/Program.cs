using System.ComponentModel;
using Task3;
using Task3.SubjectArea;
using Task3.SubjectArea.Enum;

var container = new VechicleContainer();

var testCar = new Car
{
    Name = "test1",
    MaxSpeed = 42,
    Lenght = 42,
    Weight = 42,
    Color = "Red go fasta",
    Class = CarClass.hatchback,
    WheelDrive = WheelDrive.full
};

container.Subscribe(testCar);
testCar.Subscribe(container);

var testTank = new Tank
{
    Name = "BobRoss",
    MaxSpeed = 2,
    Lenght = 222,
    Weight = 20,
    CrewSize = 2,
    ProjectileCaliber = 7,
    ShotsPerMinute = 100
};

container.Subscribe(testTank);
testTank.Subscribe(container);

testCar.MaxSpeed = 43;

testTank.ShotsPerMinute = 5454;