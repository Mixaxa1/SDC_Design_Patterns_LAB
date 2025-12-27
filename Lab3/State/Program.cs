using State;

Console.WriteLine("Creating submarine");

var submarine = new WWIISubmarine(new SubmarineEmergedState());
submarine.MoveToTarget(20);
submarine.TransitTo(new SubmarineSubmergedState());
submarine.MoveToTarget(30);
submarine.FireTorpedoes();