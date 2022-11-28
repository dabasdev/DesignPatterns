namespace PubSubDesignPattern;

public class EventArguments : EventArgs
{
    public EventArguments(string message)
    {
        Message = message;
    }

    public string Message { get; set; }
}