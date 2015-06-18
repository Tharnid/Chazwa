using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PCEF.Model; // make sure you add the model so you will have access to the interface IObjectWithState

namespace PCEF.Web.ViewModels
{
    public class SalesOrderViewModel : IObjectWithState // Make sure you add the interface
    {
        public int SalesOrderId { get; set; }
        public string CustomerName { get; set; }
        public string PONumber { get; set; }

        public string MessageToClient { get; set; }

        // have to reference ObjectState
        public ObjectState ObjectState { get; set; }
    }
}