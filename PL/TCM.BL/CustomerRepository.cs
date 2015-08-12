using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.BL
{
    public class CustomerRepository
    {
        public Customer Find(List<Customer> customerList, int customerId)
        {
            Customer foundCustomer = null;

            //foreach (var c in customerList)
            //{
            //    if (c.CustomerId == customerId)
            //    {
            //        foundCustomer = c;
            //        break;
            //    }
            //}

            //var query = from c in customerList
            //            where c.CustomerId == customerId
            //            select c;

            //foundCustomer = query.First();

            //foundCustomer = customerList.FirstOrDefault(c =>  // returns the first that satisfies the condition
            //                    c.CustomerId == customerId);  // Single lines do not require a return statement

            //foundCustomer = customerList.FirstOrDefault(c =>  // No entry found...returns default value or null
            //                {
            //                    Debug.WriteLine(c.LastName);
            //                    return c.CustomerId == customerId;
            //                });

            //foundCustomer = customerList.Where(c =>  // Where Skip One...first or default
            //                    c.CustomerId == customerId)
            //                    .Skip(1)
            //                    .FirstOrDefault();

            //foundCustomer = customerList.Where(c =>
            //                    c.CustomerId == customerId)
            //                    .Skip(1)
            //                    .FirstOrDefault();

            return foundCustomer;

        }

        // create a type for an email and Name...anonymous method
        //public dynamic IEnumerable<string> GetNamesAndEmail(List<Customer> customerList)  // dynamic allows bypassing of compile time checking
        //{
        //    var query = customerList.Select(c => new
        //    {
        //        Name = c.FirstName + ", " + c.LastName,
        //        c.EmailAddress
        //    });
        //    return query;
        //}

        public dynamic GetNamesAndEmail(List<Customer> customerList)
        {
            var query = customerList.Select(c => new
            {
                Name = c.LastName + ", " + c.FirstName,
                c.EmailAddress
            });

            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ": " + item.EmailAddress);
            }
            return query;
        }

        public IEnumerable<string> GetNames(List<Customer> customerList)
        {
            var query = customerList.Select(f => f.LastName + ", " + f.LastName);
            return query;
        }

        public dynamic GetNamesAndType(List<Customer> customerList,
                                        List<CustomerType> customerTypeList)
        {
            var query = customerList.Join(customerTypeList,
                                c => c.CustomerTypeId,
                                ct => ct.CustomerTypeId,
                                (c, ct) => new
                                {
                                    Name = c.LastName + ", " + c.FirstName,
                                    CustomerTypeName = ct.TypeName
                                });

            foreach (var item in query)
            {
                Console.WriteLine(item.Name + ": " + item.CustomerTypeName);
            }

            return query;
        }

        public List<Customer> Retrieve()
        {
            List<Customer> custList = new List<Customer>
                    {new Customer() 
                          { CustomerId = 1, 
                            FirstName="Frodo",
                            LastName = "Baggins",
                            EmailAddress = "fb@hob.me",
                            CustomerTypeId=1},
                    new Customer() 
                          { CustomerId = 2, 
                            FirstName="Bilbo",
                            LastName = "Baggins",
                            EmailAddress = "bb@hob.me",
                            CustomerTypeId=null},
                    new Customer() 
                          { CustomerId = 3, 
                            FirstName="Samwise",
                            LastName = "Gamgee",
                            EmailAddress = "sg@hob.me",
                            CustomerTypeId=1},
                    new Customer() 
                          { CustomerId = 4, 
                            FirstName="Rosie",
                            LastName = "Cotton",
                            EmailAddress = "rc@hob.me",
                            CustomerTypeId=2}};
            return custList;
        }

        public IEnumerable<Customer> SortByName(List<Customer> customerList)
        {
            return customerList.OrderBy(c => c.LastName)
                .ThenBy(c => c.FirstName);
        }

        public IEnumerable<Customer> SortByNameInReverse(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.LastName)
            //    .ThenByDescending(c => c.LastName);

            return SortByName(customerList).ToList();
        }

        public IEnumerable<Customer> SortByType(List<Customer> customerList)
        {
            //return customerList.OrderByDescending(c => c.CustomerTypeId.HasValue) // ** Null values go to the top of the list ** /
            //                    .ThenByDescending(c=>c.CustomerTypeId);

            return SortByName(customerList).Reverse();
        }

        public IEnumerable<Customer> RetrieveEmptyList()
        {
            return Enumerable.Repeat(new Customer(), 5);
        }

    }
}
