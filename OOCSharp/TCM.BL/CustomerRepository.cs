using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            // get one customer
            Customer customer = new Customer(customerId);

            // hard coded value
            if (customerId == 1)
            {
                //customer.EmailAddress = "hsolo@solo.com";
                //customer.FirstName = "Han";
                //customer.LastName = "Solo";

                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }

        // Retrieve all customers
        public List<Customer> Retrieve()
        {
            // return all Customers
            return new List<Customer>();
        }

        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }
    }
}
