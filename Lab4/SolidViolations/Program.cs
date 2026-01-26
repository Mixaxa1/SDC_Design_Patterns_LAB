using SolidViolations.DIP_Violation;
using SolidViolations.ISP_Violation;
using SolidViolations.LSP_Violation;
using SolidViolations.OCP_Violation;
using SolidViolations.SRP_Violation;

//SRP Violation, user auth service is responcible for retriving of user data with matching login info, but also does transactions between users

var userAuthService = new UserAuthorisationService();

var user1 = userAuthService.AuthoriseUser("test1", "pas");

var user2 = userAuthService.AuthoriseUser("someUser", "querty");
if (user1 != null && user2 != null)
{
    Console.WriteLine("Users authorised");
}

var transactionStatus = userAuthService.MakeTransaction(user1, user2, 200);

if (transactionStatus)
{
    Console.WriteLine("Transaction successful");
}
Console.WriteLine("\n\n");


//OCP Violation, it is imposible to add new logc for new types of cargo in cargo transportation class in any elegant maner without editing it

var seaShipping = new SeaCargoTransportation();
seaShipping.Transport(CargoType.Small);
seaShipping.Transport(CargoType.Medium);
seaShipping.Transport(CargoType.Large);

Console.WriteLine("\n\n");

//LSP Violation, fancy calculating unit inherits calculation unit but requires additional calibration wich will throw exeption in old logic that where writen before introduction of calibration in calculation units

Console.WriteLine("Use base calc unit");
var lab = new ResearchLab();
lab.calcUnit = new CalculatingUint();
lab.DoResearch();

Console.WriteLine("\nNow use new fancy calc unit");
try
{
    lab.calcUnit = new FancyCalculatingUint();
    lab.DoResearch();
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine("\n\n");

//ISP Violation, one big interface have a lot of actions while most of tools can perform 1 or 2, best to split it to many 1 action interfaces
var tools = new List<ITool>()
{
    new Multitool(),
    new Knife(),
    new CanOpener(),
    new Saw(),
    new Scriewdriver(),
};

foreach(var tool in tools)
{
    Console.WriteLine(tool);
    Console.WriteLine("Cutting:");
    tool.Cut();
    Console.WriteLine("Sawing:");
    tool.SawWood();
    Console.WriteLine("Tigthtening screw:");
    tool.TightenScrew();
    Console.WriteLine("Opening can:");
    tool.OpenCan();

    Console.WriteLine();
}

Console.WriteLine("\n\n");

//DIP Violation, kinda working and even not ugly unlike previos examples, but adding paths on vehicles will be painfull, but if were used DIP then it would be possible to just put in .pathBuiler new type of path builder that utilises common interface 

var navigator = new MapNavigator();
navigator.pathBuiler = new FootPathBuilder();

navigator.BuildAndDisplayPath((5, 2), (6, 8));