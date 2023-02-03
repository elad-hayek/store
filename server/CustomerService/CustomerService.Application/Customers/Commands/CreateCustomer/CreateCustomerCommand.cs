using CustomerService.Application.Abstractions;

namespace CustomerService.Application.Customers.Commands.CreateCustomer;

public sealed record CreateCustomerCommand(int Id, string FirstName, string LastName, string Email, string PhoneNumber) : ICommand<int>
{
    
}