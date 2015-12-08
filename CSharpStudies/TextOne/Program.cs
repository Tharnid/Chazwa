using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // strings can be in any language

            // string literals use ", char literals use '

            string myString = "h";
            char myChar = 'h';

            myString = "Hello";
            string hello = "Hello!!!";
            string name = "Han";
            int number = 135;
            var A = myString[2];
            var B = myString[1];

            string concat1 = (hello + " ") + name;
            string concat2 = hello + number + number;
            string concat3 = number + number + hello;

            string result = string.Format("{0} {1} {2}", number, number, name);

            //string interpolate = $"{number} {number} {name}";
            //Console.WriteLine(interpolate);

            Console.WriteLine(result);

            Console.WriteLine(concat1);
            Console.WriteLine(concat2);
            Console.WriteLine(concat3);

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.ReadLine();
        }
    }
}
