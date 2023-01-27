
using CustomerService.Application.Abstractions;
using CustomerService.Domain.Abstractions;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Customers.Queries.GetCustomer;

internal sealed class GetCustomerQueryByIdHandler : IQueryHandler<GetCustomerByIdQuery, Customer>
{
    private readonly ICustomerRepository _customerRepository;

    public GetCustomerQueryByIdHandler(ICustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public Task<Customer> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(_customerRepository.GetById(request.Id));
    
    }
}
