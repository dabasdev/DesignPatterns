namespace ObserverDesignPattern;

public interface ISubject
{
    void Attach(IObserver observer);
    void DeAttach(IObserver observer);

    void Notify();

    void SomeBusinessLogic();
}