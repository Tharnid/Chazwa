using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // props
            string greeting = "Hello, world!!!";
            int theLength = greeting.Length;

            // Instance Method
            Console.WriteLine(greeting.ToUpper());

            // method returns a value, does not mutate string
            greeting.ToUpper();
            Console.WriteLine(greeting);

            // Methods take arguments
            string theSubString = greeting.Substring(1, 5);

            // strings can be compared
            string name1 = "Smith";
            string name2 = "Terrell";

            bool compResult = (name1 == name2);
            Console.WriteLine(compResult);

            int comparisson = string.Compare(name1, name2);
            Console.WriteLine(comparisson);

            // Everything has a ToString instance method
            int number = 159;
            string text = number.ToString();
            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
