using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TharnApp.Biz
{
    public class Product
    {
        /// <summary>
        /// Manages products carried in inventory
        /// </summary>
        public Product()
        {
            Console.WriteLine("Product Instance Created!!!");
        }

        public Product(int productId, string productName, string description) : this() // invoke default constructor
        {
            this.productName = productName;
            this.Description = description;
            this.ProductId = productId;

            Console.WriteLine("Product Instance has a name: " + ProductName);
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string SayHello()
        {
            return "Hello " + ProductName +
                    " (" + ProductId + "): " +
                    Description;
        }

    }
}
