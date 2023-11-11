namespace Domain.Framwork
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T value);
    }
}