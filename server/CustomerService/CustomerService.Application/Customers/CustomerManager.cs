using CustomerService.Application.Customers.Commands.CreateCustomer;
using CustomerService.Application.Customers.Queries.GetCustomer;
using CustomerService.Domain.Entities;
using MediatR;

namespace CustomerService.Application.Customers;

public sealed class CustomerManager
{
    private readonly ISender _sender;

    public CustomerManager(ISender sender)
    {
        _sender = sender;
    }


    public async Task<Customer> GetCustomerById(int id, CancellationToken cancellationToken)
    {
        var query = new GetCustomerByIdQuery(id);
        var customer = await _sender.Send(query, cancellationToken);
        return customer;
    }

    public async Task<int> CreateCustomer(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        var command = new CreateCustomerCommad(request);
        var customerId = await _sender.Send(command, cancellationToken);
        return customerId;
    }
}
