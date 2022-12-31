namespace SpecificationDesignPattern.Pattern;

public interface ISpecification<T>
{
    bool IsSatisfiedBy(T item);
    ISpecification<T> And(ISpecification<T> specification);
    ISpecification<T> Or(ISpecification<T> specification);
    ISpecification<T> Not(ISpecification<T> specification);
}