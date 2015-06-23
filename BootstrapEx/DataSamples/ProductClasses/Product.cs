using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSamples
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public DateTime IntroductionDate { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public bool IsDiscontinued { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
