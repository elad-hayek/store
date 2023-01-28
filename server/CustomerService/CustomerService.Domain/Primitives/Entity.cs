namespace CustomerService.Domain.Primitives;

public abstract class Entity: IEquatable<Entity>
{
    protected Entity(int id)
    {
        Id = id;
    }

    public Entity() { }

    public int Id { get; private init; }
    public DateTime CreatedDate { get; protected set; }
    public DateTime? UpdatedDate { get; protected set; }
    public int? UpdatingUserId { get; protected set; }
    public DateTime? DeletedDate { get; protected set; }
    public int? DeletedBy { get; protected set; }


    public static bool operator ==(Entity? first, Entity? second)
    {
        return first is not null && second is not null && first.Equals(second);
    }

     public static bool operator !=(Entity? first, Entity? second)
    {
        return !(first == second);
    }

    public bool Equals(Entity? other)
    {
        if(other is null) { return false; }
        
        if(other.GetType() != GetType()) { return false; }

        return other.Id == Id;
    }

    public override bool Equals(object? obj)
    {
        if(obj is null) { return false; }
        
        if(obj.GetType() != GetType()) { return false; }

        if(obj is not Entity entity) { return false; }

        return entity.Id == Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() * 41;
    }

}
