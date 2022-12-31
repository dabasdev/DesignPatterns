using SpecificationDesignPattern.Model;
using SpecificationDesignPattern.Pattern;

namespace SpecificationDesignPattern.Specification;

public class CanDeleteSpecification<T> : Specification<T> where T : User
{
    public override bool IsSatisfiedBy(T item)
    {
        return item.Roles.Contains(Role.AccountAdmin);
    }
}