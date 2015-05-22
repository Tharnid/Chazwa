using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.BL
{
    public class Customer
    {
        public Customer()
            // Constructor Chaining
            : this(0)
        {
            
        }

        public Customer(int customerId)  // allows this to be set outside class
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        // a list does not have a default value
        public List<Address> AddressList { get; set; }

        // mod 6 adding Customer Type
        public int CustomerType { get; set; }

        //public Address WorkAddress { get; set; }
        //public Address HomeAddress { get; set; }

        public static int InstanceCount { get; set; }  // static belongs to type instead of any one instance

        private string _lastName;
        public string LastName
        {
            get
            {
                // Any code here
                return _lastName;
            }
            set
            {
                // Any code here
                _lastName = value;
            }
        }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        // Method Signature
        // Name + type of it's parameters

        // Method Overloading
        // Same name different parameters

        // Interface (of a class)
        // Contract

        // Constructor (ctor + Tab + Tab)
        // code that is run each time an instance of a class is created
        // defined at the top of the class above props and methods

        public Customer Retrieve(int customerId)
        {
            // code here
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            // code that retrieves as customers
            return new List<Customer>();
        }

        public bool Save()
        {
            // code goes here
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}

// Decoupling = Degree to which classes are dependent on each other

// Cohesion = Degree to which members of the class relate for the purpose of the class

// Separation of concerns = the idea of decomposing an application into parts with minimal overlap
// each part is reponsible for a separate concern

// Inheritance

// Customer Class (Business, Residential, Government, Educator are derived or child class of Customer (they all have an "is a" relationship to the customer class

// C# -- you can only directly inherit from one class
