using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.BL
{
    public class OrderRepository
    {
        // Retrieve one order

        public Order Retrieve(int orderId)
        {
            // create instance and pass the id
            Order order = new Order(orderId);

            // temporary hard coded value
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2015, 5, 8, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        public bool Save()
        {
            // code that saves order
            return true;
        }
    }
}
