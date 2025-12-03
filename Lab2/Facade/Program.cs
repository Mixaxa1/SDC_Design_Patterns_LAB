
using Facade;
using Facade.SubSystems;

Ship self = new Ship()
{
    XPos = 5,
    YPos = 7,
    Hp = 50
};

Ship target = new Ship()
{
    XPos = 10,
    YPos = 20,
    Hp = 50
};

var rangeFinder = new RangefinderSubsystem();
var aiming = new AimingSubsystem();
var reloading = new ReloadingSubsystem();

FireControllFacade firecontroll = new FireControllFacade(rangeFinder, aiming, reloading, self);

CommandDeckClient client = new CommandDeckClient();

client.OrderEngageTarget(firecontroll, target);
Console.WriteLine();

client.OrderEngageTarget(firecontroll, target);
Console.WriteLine();

client.OrderEngageTarget(firecontroll, target);
Console.WriteLine();

client.OrderEngageTarget(firecontroll, target);
Console.WriteLine();

client.OrderEngageTarget(firecontroll, target);
Console.WriteLine();
