using CustomerService.Application.Abstractions;

namespace CustomerService.Application.Customers.Commands.CreateCustomer;

public sealed record CreateCustomerCommad(string Name, string Email, string PhoneNumber) : ICommand<int>;
