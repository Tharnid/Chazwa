using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video11
{
    class Player
    {
        // read-write property

        public Player(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(name);
                //Name = name;
                Name = name;
            }
        }

        public string Name { get; set; }
    }
}
