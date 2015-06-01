using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MississippiCoreClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string state = "Mississippi";

            for(int i = 0; i < state.Length; i++)
            {
                Console.WriteLine(state); // state[i]
                Console.ReadLine();
            }
        }
    }
}

// string literals start and end with "