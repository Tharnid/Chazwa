using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vid13
{
    public class FieldExample
    {
        // "var" syntax not supported for fields

        string name = "Lando";

        readonly decimal dolloars;

        // static field is a var associated with class not an instance of the class
        static int count = 0;
    }
}
