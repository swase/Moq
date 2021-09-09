using System;
using System.Collections.Generic;


namespace NorthwindData.Services
{
    interface ICustomerService
    {
        List<Customer> GetCustomersList();
        public Customer GetCustomerById();
        public void CreateCustomer(Customer c);
        public void SaveCustomerChanges();
        public void RemoveCustomer(Customer c);
    }
}
