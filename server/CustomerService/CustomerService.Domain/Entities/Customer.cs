﻿using CustomerService.Domain.Primitives;

namespace CustomerService.Domain.Entities;

public sealed class Customer : AggregateRoot<int>
{
    public Customer(int id, string firstName, string lastName, string email, string phoneNumber) : base(id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string PhoneNumber { get; }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
}
