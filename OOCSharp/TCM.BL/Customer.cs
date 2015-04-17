using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.BL
{
    public class Customer
    {
        public static int InstanceCount { get; set; }

        private string _lastName;
        
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public int CustomerId { get; private set; }

        // public int MyProperty { get; private set; } propg + TAB = property with a privat setter


        public string FullName
        {
            get
            {
                string fullName = LastName;  // internal means code is internal to the component in which it is defined
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        FullName += ", ";
                    }
                    FullName += FirstName;
                }
                return FullName;
            }
            set
            {
                // nothing to see here
            }
        }
        
    }
}
