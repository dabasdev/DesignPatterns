namespace ObserverDesignPattern;

public interface IObserver
{
    void Update(ISubject subject);
}