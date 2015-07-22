using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMP.Web.Entities
{
    public class Photo
    {
        public int PhotoId { get; set; }

        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime LastLogin { get; set; }
        public bool IsMain { get; set; }
    }
}
