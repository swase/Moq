﻿using System;
using System.Collections.Generic;


namespace NorthwindData.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomerList();
        public Customer GetCustomerByID(string customerID);
        public void CreateCustomer(Customer c);
        public void SaveCustomerChanges();
        public void RemoveCustomer(Customer c);
    }
}
