using CustomerService.Domain.Primitives;

namespace CustomerService.Domain.Entities;

public sealed class Customer : Entity
{
    public Customer(int id, string name, string email) : base(id)
    {
        Name = name;
        Email = email;
    }

    public string Name { get; }
    public string Email { get; }
}
