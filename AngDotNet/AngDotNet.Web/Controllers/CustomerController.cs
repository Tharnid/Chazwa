using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngDotNet.Web.Controllers
{
    public class CustomerController : ApiController
    {
        NWEntities _db = new NWEntities();

        public IEnumerable<Customer> getAllCustomers()
        {
            _db.Configuration.ProxyCreationEnabled = false;
            return _db.Customers;
        }

        public IHttpActionResult getCustomerByCustomerID(string customerID)
        {
            _db.Configuration.ProxyCreationEnabled = false;

            var customer = _db.Customers.FirstOrDefault(c =>
                           c.CustomerID == customerID);

            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
    }
}
