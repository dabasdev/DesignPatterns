namespace SpecificationDesignPattern.Pattern;

public class AndSpecification<T> : Specification<T>
{
    private readonly ISpecification<T> _first;
    private readonly ISpecification<T> _second;

    public AndSpecification(ISpecification<T> first, ISpecification<T> second)
    {
        _first = first;
        _second = second;
    }
    public override bool IsSatisfiedBy(T item)
    {
        return _first.IsSatisfiedBy(item) && _second.IsSatisfiedBy(item);
    }
}