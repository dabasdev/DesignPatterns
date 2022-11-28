namespace DynamicRuleEngine.Rules;

public class ItRule : IRule
{
    public bool IsApplicable(User user)
    {
        return user.Department == Department.It;
    }

    public void Execute(User user)
    {
        Console.WriteLine("Rule For IT");
    }
}