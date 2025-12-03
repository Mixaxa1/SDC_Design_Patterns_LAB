using Bridge;
using Bridge.ConcreteImplementation;
using Bridge.ImprovedAbstractions;

TTRPGPlayerClient player = new TTRPGPlayerClient();

TTRPG gameSystem;
gameSystem = new TTRPG(new SparklyDices());

player.AskToMakeSkillCheck(gameSystem, 15, 4);
Console.WriteLine();

gameSystem = new DarkHeresy(new SparklyDices());

player.AskToMakeSkillCheck(gameSystem, +10, 39);
Console.WriteLine();

gameSystem = new Pathfinder(new GliterDices());

player.AskToMakeSkillCheck(gameSystem, 8, -2);