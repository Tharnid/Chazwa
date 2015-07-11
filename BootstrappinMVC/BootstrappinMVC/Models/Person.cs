using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrappinMVC.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool LikesMusic { get; set; }
        public ICollection<string> Skills { get; set; }
    }
}