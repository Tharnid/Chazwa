using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            // Address List
            // customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            // Collaborative Relationship
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            // This will retrieve the customer and it's address(es)

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

        public bool Save(Customer customer)
        {
            // Code that saves the defined customer
            return true;
        }
    }
}
