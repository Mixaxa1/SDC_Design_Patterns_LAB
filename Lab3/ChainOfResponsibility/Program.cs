using ChainOfResponsibility;

var handler1 = new EmailAddGreetengHandler();
var handler2 = new EmailAddEndHandler();

handler1.SetNext(handler2);

var someEmail = "We must inform you that your subscriprion is terminated";

var handledEmail = handler1.Handle(someEmail);

Console.WriteLine(handledEmail);
