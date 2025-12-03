
using Flyweight;

FlyweightFactory factory = new FlyweightFactory(
    new EnemyFlyweight { Name = "Zombie", Model = "ZombieModel", Sounds = ["ugh", "aaaahh", "rrrrr"] },
    new EnemyFlyweight { Name = "Skeleton", Model = "SkeletonModel", Sounds = ["kxkk", "hrrs", "ktktktt"] });
factory.ListFlyweights();
Console.WriteLine();

var zombieFlyweight = factory.GetFlyweight("Zombie");
if (zombieFlyweight != null)
{
    var weakZ = new EnemyContext(zombieFlyweight)
    {
        Def = 0,
        Dmg = 1
    };

    var strongZ = new EnemyContext(zombieFlyweight)
    {
        Def = 5,
        Dmg = 3
    };

    weakZ.Attack();
    strongZ.Attack();
    weakZ.Attack();
    strongZ.Attack();

    weakZ.GetHit(10);
    strongZ.GetHit(10);
}

var banditFlyweight = factory.GetFlyweight("Bandint");
if (banditFlyweight == null)
{
    factory.CreateNewFlyweight(new EnemyFlyweight()
    {
        Name = "Bandit",
        Model = "BanditModel",
        Sounds = ["You done for", "You shouldn't have come here."]
    });

    banditFlyweight = factory.GetFlyweight("Bandit");
}
Console.WriteLine();
factory.ListFlyweights();
Console.WriteLine();

var bandCap = new EnemyContext(banditFlyweight)
{
    Def = 15,
    Dmg = 10
};
var bandGrunt = new EnemyContext(banditFlyweight)
{
    Def = 8,
    Dmg = 6
};

bandCap.Attack();
bandGrunt.Attack();

bandGrunt.GetHit(10);
bandCap.GetHit(20);