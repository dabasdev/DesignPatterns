using StrategyDesignPattern.ExampleA;

#region ExampleA

Console.WriteLine("Hello, World!");

Console.WriteLine();

var context = new Context();

Console.WriteLine("Context: Normal Strategy");

context.SetStrategy(new ConcreteStrategyA());
context.DoSomeLogic();

Console.WriteLine();


Console.WriteLine("Context: Reverse Strategy");

context.SetStrategy(new ConcreteStrategyB());
context.DoSomeLogic();

Console.ReadKey();

#endregion