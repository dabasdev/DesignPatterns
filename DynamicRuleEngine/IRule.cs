namespace DynamicRuleEngine;

public interface IRule
{
    bool IsApplicable(User user);
    void Execute(User user);
}