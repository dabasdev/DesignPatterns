using SpecificationDesignPattern.Model;
using SpecificationDesignPattern.Pattern;

namespace SpecificationDesignPattern.Specification;

public class HasValidNameSpecification<T> : Specification<T> where T : User
{
    public override bool IsSatisfiedBy(T item)
    {
        return $"{item.FirstName} {item.LastName}".Length > 10;
    }
}