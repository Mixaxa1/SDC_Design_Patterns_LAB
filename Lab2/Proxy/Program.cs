using Proxy;

var client = new Client();

var whiteList = new List<string> { "Alex", "Sergei", "Dima" };
INightClubEntrance entrance = new NightClubEntrance();
INightClubEntrance proxy = new FaceControlProxy(entrance, whiteList);

Console.WriteLine("Without proxy");

Console.WriteLine("\nVisitor on white list");
client.SendVisitorToEntrance(entrance, whiteList[1]);

Console.WriteLine("\nVisitor not on white list");
client.SendVisitorToEntrance(entrance, "Ivan");

Console.WriteLine("\n\nWith proxy");

Console.WriteLine("\nVisitor on white list");
client.SendVisitorToEntrance(proxy, whiteList[2]);

Console.WriteLine("\nVisitor not on white list");
client.SendVisitorToEntrance(proxy, "Ivan");