namespace CustomerService.Domain.Primitives;

public abstract class Entity
{
    protected Entity(int id)
    {
        Id = id;
        CreatedDate = DateTime.Now;
    }

    protected Entity() { }

    public int Id { get; protected set; }
    public DateTime CreatedDate { get; protected set; }
    public DateTime? UpdatedDate { get; protected set; }
    public DateTime? DeletedDate { get; protected set; }
    public int? DeletedBy { get; protected set; }
}
