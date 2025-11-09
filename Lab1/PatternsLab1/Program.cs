using PatternsLab1;

Console.WriteLine("Singleton");
Console.WriteLine("From get instance");
Console.WriteLine(SingletonSettings.GetInstance().GetHashCode()); ;

Console.WriteLine("From get instance second time");
Console.WriteLine(SingletonSettings.GetInstance().GetHashCode());


Console.WriteLine("Adding to fresh got instance");
var sett = Console.ReadLine();
var val = Console.ReadLine();

SingletonSettings.GetInstance().SetSetting(sett, val);

Console.WriteLine("Read from fresh got instance");

var read_val = SingletonSettings.GetInstance().GetSetting(sett);

Console.WriteLine(read_val);