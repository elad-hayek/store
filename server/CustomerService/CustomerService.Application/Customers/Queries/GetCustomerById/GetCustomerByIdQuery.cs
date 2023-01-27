using CustomerService.Application.Abstractions;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Customers.Queries.GetCustomer;

public sealed record GetCustomerByIdQuery(int Id) : IQuery<Customer>;
