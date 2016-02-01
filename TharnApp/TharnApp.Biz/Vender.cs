using TharnApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TharnApp.Biz
{
    /// <summary>
    /// Manages the vendors from whom we purchase our inventory.
    /// </summary>
    public class Vendor
    {
        public int VendorId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }

        // Building Method Demo
        /// <summary>
        /// Sends a product order to the vendor
        /// </summary>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public bool PlaceOrder(Product product, int quantity)
        {
            // guard statements
            if (product == null)
                throw new ArgumentNullException(nameof(product));  // C# 6 nameof || before that "product"
            // qty > 0
            if (quantity <= 0)
                throw new ArgumentNullException(nameof(quantity));

            var success = false;

            var orderText = "Order from Acme, Inc" + System.Environment.NewLine +
                            "Product: " + product.ProductCode +
                                                    System.Environment.NewLine +
                            "Quantity: " + quantity;

            var emailService = new EmailService();
            var confirmation = emailService.SendMessage("New Order", orderText,
                                                                     this.Email);

            if (confirmation.StartsWith("Message sent:"))
            {
                success = true;
            }

            return success;
        }

        /// <summary>
        /// Sends an email to welcome a new vendor.
        /// </summary>
        /// <returns></returns>
        public string SendWelcomeEmail(string message)
        {
            var emailService = new EmailService();
            var subject = ("Hello " + this.CompanyName).Trim();
            var confirmation = emailService.SendMessage(subject,
                                                        message,
                                                        this.Email);
            return confirmation;
        }
    }
}
