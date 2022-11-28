// See https://aka.ms/new-console-template for more information

using DynamicRuleEngine;
using DynamicRuleEngine.Rules;

Console.WriteLine("Hello, World!");


Console.WriteLine();

var user = new User
{
    Id = 1, Name = "Ahmed", Age = 45, Department = Department.Hr
};

var rules = new List<IRule>
{
    new HrRule(),
    new ItRule()
};

new RuleEngine(rules).Execute(user);