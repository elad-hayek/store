namespace CustomerService.Domain.Primitives;

public abstract class AggregateRoot<TIdType> : Entity<TIdType> where TIdType : notnull
{
    protected AggregateRoot(TIdType id) : base(id)
    {
    }
}
