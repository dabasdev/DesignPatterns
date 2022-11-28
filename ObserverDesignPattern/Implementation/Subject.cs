namespace ObserverDesignPattern.Implementation;

public class Subject : ISubject
{
    private readonly List<IObserver> _observers = new();
    public int State { get; set; }

    public void Attach(IObserver observer)
    {
        Console.WriteLine("Subject : Attach an Observer.");
        _observers.Add(observer);
    }

    public void DeAttach(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine("Subject : DeAttach an Observer.");
    }

    public void Notify()
    {
        Console.WriteLine("Subject : Notifying Observer .....");

        _observers.ForEach(x => x.Update(this));
    }

    public void SomeBusinessLogic()
    {
        Console.WriteLine("\n Subject: I'm doing something important ...");
        State = new Random().Next(0, 10);

        Thread.Sleep(15);

        Console.WriteLine($"\n Subject: My State has changed to: {State}");
        Notify();
    }
}