// See https://aka.ms/new-console-template for more information

using ObserverDesignPattern.Implementation;

Console.WriteLine("Hello, World!");

var subject = new Subject();

var observerA = new ConcreteObserverA();
subject.Attach(observerA);

var observerB = new ConcreteObserverB();
subject.Attach(observerB);

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

subject.DeAttach(observerB);

subject.SomeBusinessLogic();

Console.ReadKey(true);