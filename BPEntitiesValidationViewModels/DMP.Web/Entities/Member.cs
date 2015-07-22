using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;


namespace DMP.Web.Entities
{
    public class Member
    {
        public int MemberId { get; set; }

        public string Username { get; set; }
        public DateTime LastLogin { get; set; }
        public DateTime Created { get; set; }

        public Profile Profile  { get; set; }

        // collection because a member can have multiple 
        public ICollection<Message> Messages { get; set; }
        public ICollection<Favorite> Favorites { get; set; } 
    }
}