
using CustomerService.Application.Abstractions;
using CustomerService.Domain.Abstractions;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Customers.Queries.GetCustomer;

internal sealed class GetCustomerQueryHandler : IQueryHandler<GetCustomerQuery, Customer>
{
    private readonly ICustomerRepository _customerRepository;

    public GetCustomerQueryHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Task<Customer> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_customerRepository.GetById(request.Id));
    
    }
}
