using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bananas
{
    class Program
    {
        static void Main(string[] args) // scope is the portion of program to which the variable is referred to by name
        {
            var numberOfBananas = 3;
            Console.WriteLine("Number of bananas: " + " " + numberOfBananas);
            var numberOfApples = 2;
            Console.WriteLine("Number of apples: " + " " + numberOfApples);
            Console.ReadLine();
        }
    }
}
