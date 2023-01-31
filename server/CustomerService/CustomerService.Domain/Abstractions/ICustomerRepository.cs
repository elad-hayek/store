using CustomerService.Domain.Entities;

namespace CustomerService.Domain.Abstractions;

public interface ICustomerRepository : IRepository<Customer, int>
{

}
