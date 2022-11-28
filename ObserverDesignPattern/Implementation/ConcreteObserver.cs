namespace ObserverDesignPattern.Implementation;

public class ConcreteObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as Subject)!.State < 3) Console.WriteLine("ConcreteObserverA: Reacted to the event.");
    }
}

public class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        if ((subject as Subject)!.State is 0 or >= 2) Console.WriteLine("ConcreteObserverB: Reacted to the event.");
    }
}