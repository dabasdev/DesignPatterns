namespace PubSubDesignPattern;

public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.MyEvent += Update;
    }

    public void UnSubscribe(Publisher publisher)
    {
        publisher.MyEvent -= Update;
    }

    public void Update(object? sender, EventArguments args)
    {
        if (sender is Publisher pub) Console.WriteLine(pub.Name + "  sent a message : " + args.Message);
    }
}