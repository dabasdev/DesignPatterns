namespace SpecificationDesignPattern.Model;

public class User : Entity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string PasswordConfirmed { get; set; } = string.Empty;
    public List<Role> Roles { get; set; } = new();
}

public enum Role
{
    SuperAdmin,
    AccountAdmin,
    SupportAdmin
}