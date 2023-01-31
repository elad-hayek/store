using CustomerService.Domain.Abstractions;

namespace CustomerService.Domain.Primitives;

public abstract class Entity<TIdType> : EqualById<Entity<TIdType>, TIdType> where TIdType : notnull
{
    protected Entity(TIdType id) : base(id)
    {
        Id = id;
    }


    public DateTime CreatedDate { get; protected set; }
    public DateTime? UpdatedDate { get; protected set; }
    public int? UpdatingUserId { get; protected set; }
    public DateTime? DeletedDate { get; protected set; }
    public int? DeletedBy { get; protected set; }


}
