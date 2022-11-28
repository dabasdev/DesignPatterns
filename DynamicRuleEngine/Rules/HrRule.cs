namespace DynamicRuleEngine.Rules;

public class HrRule : IRule
{
    public bool IsApplicable(User user)
    {
        return user.Age > 40;
    }

    public void Execute(User user)
    {
        Console.WriteLine("Rule For Hr");
    }
}