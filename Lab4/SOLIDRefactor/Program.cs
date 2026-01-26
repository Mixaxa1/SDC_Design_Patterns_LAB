using SOLIDRefactor;
using SOLIDRefactor.Handlers;
using SOLIDRefactor.Interfaces;

List<string> birdsToTest = new List<string>
{
    "Pinguin",
    "Sparrow"
};

List<IBirdActivityHandler> birdRoutine = new List<IBirdActivityHandler>()
{
    new BirdSearchForMateHandler(),
    new BirdMovesHandler(),
    new BirdRaiseChildHandler()
};

var birdLife = new BirdLife();
birdLife.SetBirdRoutine(birdRoutine);

var birdProdycer = new BirdProducer();

foreach (var birdName in birdsToTest)
{
    IBird? bird = birdProdycer.ProduceBird(birdName);
    if (bird != null)
    {
        birdLife.DoBirdActions(bird);
    }
}