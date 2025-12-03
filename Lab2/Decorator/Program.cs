
using Decorator;
using Decorator.DecoratedClass;
using Decorator.Decorators;

YoutubeClient client = new YoutubeClient();

Console.WriteLine();
Console.WriteLine("Youtube");
Console.WriteLine();

YoutubeVideo someVideo = new SomeTutorialVideo();
someVideo = new PrerollAdDecorator(someVideo);
someVideo = new PremiumPrerollAdDecorator(someVideo);
someVideo = new PostRollAdDecorator(someVideo);

client.WatchVideo(someVideo);

Console.WriteLine("Youtube with Premium");
Console.WriteLine();

someVideo = new SomeTutorialVideo();
someVideo = new PremiumPrerollAdDecorator(someVideo);

client.WatchVideo(someVideo);

Console.WriteLine();
Console.WriteLine("Youtube with AdBlock");
Console.WriteLine();

someVideo = new SomeTutorialVideo();

client.WatchVideo(someVideo);