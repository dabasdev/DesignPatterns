namespace DynamicRuleEngine;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public Department Department { get; set; }
}

public enum Department
{
    It,
    Account,
    Hr,
    Other
}