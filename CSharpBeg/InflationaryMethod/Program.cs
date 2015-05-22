using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InflationaryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            float house = 200000.0f;
            float salary = 75000.0f;

            // explicitly pass variables
            AdjustForInflation(ref house, ref salary);
            Console.WriteLine("** Values After Inflation Adjustment **");
            Console.WriteLine("Home:  " + house);
            Console.WriteLine("Salary:  " + salary);
            Console.ReadLine();
        }

        static void AdjustForInflation(ref float home, ref float salary)
        {
            const float RATE = 1.03f;
            home *= RATE;
            salary *= RATE;
        }
    }
}
