﻿using CustomerService.Application.Abstractions;
using CustomerService.Domain.Abstractions;
using CustomerService.Domain.Entities;

namespace CustomerService.Application.Customers.Commands.CreateCustomer;

internal sealed class CreateCustomerCommandHandler : ICommandHandler<CreateCustomerCommand, int>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IUnitOfWork unitOfWork)
    {
        _customerRepository = customerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = new Customer(request.Id, request.FirstName, request.LastName, request.Email, request.PhoneNumber);
        _customerRepository.Insert(customer);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        return customer.Id;
    }
}
