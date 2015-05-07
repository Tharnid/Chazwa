using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        // properties
        public DateTimeOffset? OrderDate { get; set; }  // can hold value or null
        public int OrderId { get; private set; }

        public Order Retrieve(int orderId)
        {
            // code that retrieves a defined order
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
