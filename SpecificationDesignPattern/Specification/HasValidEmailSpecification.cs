using SpecificationDesignPattern.Model;
using SpecificationDesignPattern.Pattern;

namespace SpecificationDesignPattern.Specification;

public class HasValidEmailSpecification<T> : Specification<T> where T : User
{
    public override bool IsSatisfiedBy(T item)
    {
        return item.Email.Contains("@");
    }
}