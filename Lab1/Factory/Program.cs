
using Factory;

var excFactory = new ExcavatorFactory();
var exc = excFactory.FactoryMethod();
exc.Excavate();

var bullFactory = new BulldozerFactory();
var bulldozer =  bullFactory.FactoryMethod();
bulldozer.Excavate();