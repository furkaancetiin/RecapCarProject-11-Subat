﻿using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {  
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetById(int customerId);

        IDataResult<Customer> GetCustomerByUserId(int userId);
        IResult Add(Customer customer);
        IResult Update(Customer customer);
        IResult Delete(Customer customer);
        
    }
}
