﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindData.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly NorthwindContext _context;

        public CustomerService(NorthwindContext context)
        {
            _context = context;
        }

        public CustomerService()
        {
            _context = new NorthwindContext();
        }

        public void CreateCustomer(Customer c)
        {
            _context.Customers.Add(c);
            _context.SaveChanges();
        }

        public Customer GetCustomerByID(string customerID)
        {
            return _context.Customers.Where(c => c.CustomerId == customerID).FirstOrDefault();
        }

        public List<Customer> GetCustomerList()
        {
            return _context.Customers.ToList();
        }

        public void RemoveCustomer(Customer c)
        {
            _context.Customers.Remove(c);
            _context.SaveChanges();
        }

        public void SaveCustomerChanges()
        {
            _context.SaveChanges();
        }
    }
}
