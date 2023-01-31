namespace CustomerService.Domain.Abstractions;

public abstract class EqualById<TType, TIdType>: IEquatable<TType>, IHasIdentity<TIdType> 
    where TType: class, IHasIdentity<TIdType>
    where TIdType : notnull
    
{
    public virtual TIdType Id { get; init; }

    public EqualById(TIdType id)
    {
        Id = id;
    }

    public static bool operator ==(EqualById<TType, TIdType>? first, EqualById<TType, TIdType>? second)
    {
        return first is not null && second is not null && first.Equals(second);
    }

    public static bool operator !=(EqualById<TType, TIdType> first, EqualById<TType, TIdType> second)
    {
        return !(first == second);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) { return false; }

        if (obj.GetType() != GetType()) { return false; }

        if (obj is not TType currentType) { return false; }

        return currentType.Id.Equals(Id);
    }

    public bool Equals(TType? other)
    {
        if (other is null) { return false; }

        if (other.GetType() != GetType()) { return false; }

        return other.Id.Equals(Id);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() * 41;
    }

}
