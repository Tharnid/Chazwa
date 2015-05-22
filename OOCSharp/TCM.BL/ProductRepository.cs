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

            Object myObject = new Object();
            Console.WriteLine("Object: " + myObject.ToString());
            Console.WriteLine("Product: " + product.ToString());
            Console.ReadLine();

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;
            }
            return product;

                //CurrentPrice = 1545.50M,
                //ProductDescription = "Ummm...a part of a ship",
                //ProductName = "Flux Capacitor"
        }

        public bool Save()
        {
            // Code that saves the defined product
            return true;
        }
    }
}
