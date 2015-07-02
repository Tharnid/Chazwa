using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SolutionName.Model;
using System.ComponentModel.DataAnnotations;

namespace SolutionName.Web.ViewModels
{
    public class SalesOrderViewModel : IObjectWithState
    {
        public SalesOrderViewModel()
        {
            SalesOrderItems = new List<SalesOrderItemViewModel>();
            SalesOrderItemsToDelete = new List<int>();
        }

        public int SalesOrderId { get; set; }
        
        [Required(ErrorMessage="Server: you cannot create a sales order unless you provide the customer's name!!!")]
        [StringLength(30, ErrorMessage="Server: Customer names must be 30 or less characters!!!")]
        public string CustomerName { get; set; }

        [StringLength(10, ErrorMessage="Server: PO numbers must be 10 or less characters!!!")]
        public string PONumber { get; set; }

        public List<SalesOrderItemViewModel> SalesOrderItems { get; set; }

        public List<int> SalesOrderItemsToDelete { get; set; }

        public string MessageToClient { get; set; }

        public ObjectState ObjectState { get; set; }
    }
}