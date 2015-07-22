using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMP.Web.Entities
{
    public class Message
    {
        public int MessageId { get; set; }

        public string Body { get; set; }
        public DateTime MessageSent { get; set; }
        public bool Read { get; set; }

        public int RecipientId { get; set; }
        public int ParentId { get; set; }  

        // Avoid lazy loading in web dev...don't want to call out to web server when you need objects
    }
}
