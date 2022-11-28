namespace StrategyDesignPattern.ExampleA;

public class Context
{
    private IStrategy _strategy;

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void DoSomeLogic()
    {
        Console.WriteLine("Context:  Sorting data using the Strategy");
        var result = _strategy.DoSomeThing(new List<string> { "a", "b", "c", "d", "e" });

        var str = string.Empty;

        foreach (var item in (result as List<string>)!) str += item + ",";

        Console.WriteLine(str);
    }
}