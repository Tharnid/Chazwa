using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccurualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TOTAL_YEARS = 5;
            double accrualRate;

            // Pass uninitialize rate explicitly by reference
            GetAccrualRate(out accrualRate, TOTAL_YEARS);
            Console.WriteLine("Accrual rate: " + accrualRate);
            Console.ReadLine();
        }

        static void GetAccrualRate(out double interest, double years)
        {
            const double INTEREST_RATE = 1.05;
            interest = Math.Pow(INTEREST_RATE, years);
        }
    }
}

// value types - store value directly

// reference types - do not store value, but store a reference to the value