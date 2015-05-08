using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product();

            if (productId == 2)
            {
                product.ProductName = "Flux Capacitor";
                product.ProductDescription = "Ummm...a part of a ship";
                product.CurrentPrice = 1545.50M;
            }

            return product;
        }

        public bool Save()
        {
            // Code that saves the defined product
            return true;
        }
    }
}
