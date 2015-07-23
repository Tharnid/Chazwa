using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMP.Web.Entities
{
    public class Interest
    {
        public int InterestId { get; set; }

        // New Type
        public InterestType InterestType { get; set; }
    }
}
