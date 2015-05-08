﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TPM.WebAPI.Models;

namespace TPM.WebAPI.Controllers
{
        [EnableCorsAttribute("http://localhost:51088", "*", "*")]
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            //return new string[] { "value1", "value2" };
            var prodRepo = new ProductRepository();

            return prodRepo.Retrieve();
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