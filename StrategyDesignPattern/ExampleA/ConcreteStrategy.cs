namespace StrategyDesignPattern.ExampleA;

public class ConcreteStrategyA : IStrategy
{
    public object? DoSomeThing(object data)
    {
        var list = data as List<string>;
        list?.Sort();
        return list;
    }
}

public class ConcreteStrategyB : IStrategy
{
    public object? DoSomeThing(object data)
    {
        var list = data as List<string>;
        list?.Sort();
        list?.Reverse();
        return list;
    }
}