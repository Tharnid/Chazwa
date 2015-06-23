using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrapBusSetup.Models
{
    public class UserData
    {
        public UserData()
        {

        }

        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public bool IsIn401k { get; set; }
        public bool IsInHealthcare { get; set; }
    }
}