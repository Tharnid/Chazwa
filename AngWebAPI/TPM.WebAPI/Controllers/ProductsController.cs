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
        // GET: api/Products
        //[EnableQuery()]
        //public IQueryable<Product> Get()
        //{
        //    var productRepository = new ProductRepository();
        //    return productRepository.Retrieve().AsQueryable();
        //}

            [EnableQuery()]
            public IQueryable<Product> Get()
            {
                var productRepository = new ProductRepository();
                return productRepository.Retrieve().AsQueryable();
            }

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
        public void Post([FromBody]Product product)
        {
            var productRepository = new Models.ProductRepository();
            var newProduct = productRepository.Save(product);
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]Product product)
        {
            var productRepository = new Models.ProductRepository();
            var updatedProduct = productRepository.Save(id, product);
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
