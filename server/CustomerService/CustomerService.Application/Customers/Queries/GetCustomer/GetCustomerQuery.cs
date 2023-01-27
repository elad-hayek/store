using CustomerService.Application.Abstractions;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Customers.Queries.GetCustomer;

public sealed record GetCustomerQuery(int Id) : IQuery<Customer>;
