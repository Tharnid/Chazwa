using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCM.BL
{
    public abstract class EntityBase // Abstract classes cannot be instantiated and can only be used as a base class for other classes...it is never used on its own...cannot use "new" keyword
    {
        public enum EntityStateOption
        {
            Active,
            Deleted
        }

        // only be used as a base class
        // Sealed class -  is a class the cannot be extended through inheritance...no other class can inherit from it
        // sealing a class prevents extension and customization

        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; } // public allows us to access this from the repository class

        public bool IsValid
        {
            get
            {
                return Validate();
            }
        }

        public abstract bool Validate();
    }
}

// Concrete class

// can be instantiated with "new" keyword
