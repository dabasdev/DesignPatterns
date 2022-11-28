namespace PubSubDesignPattern;

public class Publisher
{
    public string Name { get; set; } = string.Empty;

    public event EventHandler<EventArguments>? MyEvent;

    public virtual void Notify(string message)
    {
        var args = new EventArguments(message);

        MyEvent?.Invoke(this, args);
    }
}