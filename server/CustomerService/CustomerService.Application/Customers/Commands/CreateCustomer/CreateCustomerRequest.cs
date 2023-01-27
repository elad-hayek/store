namespace CustomerService.Application.Customers.Commands.CreateCustomer;

public sealed class CreateCustomerRequest
{
    public CreateCustomerRequest(string firstName, string lastName, string email, string phoneNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string PhoneNumber { get; }
}
