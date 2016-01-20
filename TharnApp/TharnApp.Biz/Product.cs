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

        public const double InchesPerMeter = 39.37;
        public readonly decimal MinimumPrice;

        public Product()
        {
            Console.WriteLine("Product Instance Created!!!");
            this.MinimumPrice = .96m;
            this.ProductVendor = new Vendor();
            // setting intial category
            this.Category = "Tools";
        }

        public Product(int productId, string productName, string description) : this() // invoke default constructor
        {
            this.ProductName = productName;
            this.Description = description;
            this.ProductId = productId;

            if (ProductName.StartsWith("Bulk"))
            {
                this.MinimumPrice = 9.99m;
            }

            Console.WriteLine("Product Instance has a name: " + ProductName);
        }

        private DateTime? availabilityDate;

        public DateTime? MyProperty
        {
            get { return availabilityDate; }
            set { availabilityDate = value; }
        }


        //private string productName;

        //public string ProductName
        //{
        //    get { return productName; }
        //    set { productName = value; }
        //}

        private string productName;

        public string ProductName
        {
            get {
                var formattedValue = productName?.Trim(); // trim any leading or traling spaces
                return formattedValue; // If null then null if not then dot lol
            }

            set
            {
                if (value.Length < 3)
                {
                    ValidationMessage = "Product Name must be at least 3 characters";
                }
                else if (value.Length > 20)
                {
                    ValidationMessage = "Product Name cannot be more than 20 characters";
                }
                else
                {
                    productName = value;
                }
            }
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

        // Auto implemented props
        // public string Category { get; set; }
        // changing getter to internal
        internal string Category {  get; set; }  // private set causes error in test
        public int SequenceNumber { get; set; } = 1;


        public string ValidationMessage { get; private set; }

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
