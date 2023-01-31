using CustomerService.Application.Abstractions;

namespace CustomerService.Application.Customers.Commands.CreateCustomer;

public sealed record CreateCustomerCommad(int Id, string FirstName, string LastName, string Email, string PhoneNumber) : ICommand<int>
{
    public CreateCustomerCommad(CreateCustomerRequest request) :
        this(default, request.FirstName, request.LastName, request.Email, request.PhoneNumber)
    {
    }
}