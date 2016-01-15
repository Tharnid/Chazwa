using System;
using TharnApp.Common;
using static TharnApp.Common.LoggingService;
using static TharnApp.Common.EmailService;
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
            this.ProductVendor = new Vendor();
        }

        public Product(int productId, string productName, string description) : this() // invoke default constructor
        {
            this.productName = productName;
            this.Description = description;
            this.ProductId = productId;

            Console.WriteLine("Product Instance has a name: " + ProductName);
        }

        //private DateTime availabilityDate;

        //public DateTime MyProperty
        //{
        //    get { return availabilityDate; }
        //    set { availabilityDate = value; }
        //}

        private DateTime? availabilityDate;

        public DateTime? MyProperty
        {
            get { return availabilityDate; }
            set { availabilityDate = value; }
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

        //private Vendor productVendor;

        //public Vendor ProductVendor
        //{
        //    get { return productVendor; }
        //    set { productVendor = value; }
        //}

        private Vendor productVendor;

        public Vendor ProductVendor
        {
            get
            {
                if (productVendor == null)
                {
                    productVendor = new Vendor(); // create if null
                }
                return productVendor;
            }
            set { productVendor = value; }
        }


        public string SayHello()
        {
            //var vendor = new Vendor();

            //vendor.SendWelcomeEmail("Message from product");

            var emailService = new EmailService();

            var confirmation = emailService.SendMessage("New Product",
                this.productName, "sales@abc.com");

            var result = LogAction("Saying Hello");

            return "Hello " + ProductName +
                    " (" + ProductId + "): " +
                    Description +
                    " Available on: " +
                    availabilityDate?.ToShortDateString();
        }

    }
}
