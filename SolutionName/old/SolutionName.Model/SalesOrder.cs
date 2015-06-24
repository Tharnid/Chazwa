using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Model
{
    public class SalesOrder : IObjectWithState
    {
        // Constructor
        public SalesOrder()
        {
            // Make sure the child is ready to use by putting it in the constructor
            SalesOrderItems = new List<SalesOrderItem>();
        }

        public int SalesOrderId { get; set; }
        public string CustomerName { get; set; }
        public string PONumber { get; set; }

        public ObjectState ObjectState { get; set; }

        // Adding SalesOrderItem
        public virtual List<SalesOrderItem> SalesOrderItems { get; set; }
    }
}
