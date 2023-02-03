using CustomerService.Application.Customers.Commands.CreateCustomer;
using CustomerService.Application.Customers.Queries.GetCustomer;
using CustomerService.Domain.Entities;
using MapsterMapper;
using MediatR;

namespace CustomerService.Application.Customers;

public sealed class CustomerManager
{
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public CustomerManager(ISender sender, IMapper mapper)
    {
        _sender = sender;
        _mapper = mapper;
    }


    public async Task<Customer> GetCustomerById(int id, CancellationToken cancellationToken)
    {
        var query = new GetCustomerByIdQuery(id);
        var customer = await _sender.Send(query, cancellationToken);
        return customer;
    }

    public async Task<int> CreateCustomer(CreateCustomerRequest request, CancellationToken cancellationToken)
    {
        var command = _mapper.Map<CreateCustomerCommand>(request);
        var customerId = await _sender.Send(command, cancellationToken);
        return customerId;
    }
}
