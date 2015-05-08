using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors; // added CORS
using System.Web.OData; // added OData
using TPM.WebAPI.Models;

namespace TPM.WebAPI.Controllers
{
        [EnableCorsAttribute("http://localhost:51088", "*", "*")]
    public class ProductsController : ApiController
    {
        // Enable IQueryable Step 1 to adding OData queries
        [EnableQuery()]
        public IQueryable<Product> Get()
        {
            var prodRepo = new ProductRepository();

            return prodRepo.Retrieve().AsQueryable();
        }

        public IEnumerable<Product> Get(string search)
        {
            var prodRepo = new ProductRepository();
            var products = prodRepo.Retrieve();
            return products.Where(p => p.ProductCode.Contains(search));
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}

// OData Query Options

// $top = returns top N results = $top:3

// $skip = skips N results = $skip:1

// $orderby = sorts the results = $orderby:"ProdNameDesc"

// $filter = filters results based on an expression = $filter:"Price gt 5"

// $select = Selects the properties to include in the response = $select:"ProductName, ProductCode" 
