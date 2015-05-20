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

        //public IEnumerable<Product> Get(string search)
        //{
        //    var prodRepo = new ProductRepository();
        //    var products = prodRepo.Retrieve();
        //    return products.Where(p => p.ProductCode.Contains(search));
        //}

        // GET: api/Products/5
        public Product Get(int id)
        {
            Product product;
            var productRepository = new ProductRepository();

            if (id > 0)
            {
                var products = productRepository.Retrieve();
                product = products.FirstOrDefault(p => p.ProductId == id);
            }
            else
            {
                product = productRepository.Create();
            }
            return product;
        }

        // POST: api/Products
        public void Post([FromBody]Product product) // [fromBody] defines to web api parameter value comes from the body of the request, 
            // otherwise URL of request
        {
            var productRepository = new Models.ProductRepository();
            var newProduct = productRepository.Save(product);
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]Product product) // first defined by URL and the second is defined by the body of the request
        {
            var productRepository = new Models.ProductRepository();
            // pass product id and object to the save method
            var updateProduct = productRepository.Save(id, product);
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
