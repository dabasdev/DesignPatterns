namespace DynamicRuleEngine.Rules;

public class RuleEngine
{
    private readonly IEnumerable<IRule> _rules;

    public RuleEngine(IEnumerable<IRule> rules)
    {
        _rules = rules;
    }

    public void Execute(User user)
    {
        if (_rules.Any())
            _rules.Where(x => x.IsApplicable(user)).ToList().ForEach(x => { x.Execute(user); });
    }
}