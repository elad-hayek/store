﻿using CustomerService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Domain.Abstractions
{
    public interface ICustomerRepository: IRepository<Customer>
    {
       
    }
}