using SpecificationDesignPattern.Model;

namespace SpecificationDesignPattern.AnotherExample;

public class UserById : Specifications<User>
{
    public UserById(int id) : base(user => user.Id == id)
    {
        //AddInclude(x => x.Email);
    }
}