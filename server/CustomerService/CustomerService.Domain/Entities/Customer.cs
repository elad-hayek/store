using CustomerService.Domain.Primitives;

namespace CustomerService.Domain.Entities;

public sealed class Customer : Entity
{
    public Customer( string name, string email, string phoneNumber)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public string Name { get; }
    public string Email { get; }
    public string PhoneNumber { get; }
}
