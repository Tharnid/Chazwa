using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceMethod
{
    class Program
    {
        // place constants and methods to be used in MAIN up here
        const int FIRST_PRICE = 0;

        static void Main(string[] args)
        {
            decimal[] prices = { 9.99m };
            ShowPrices(prices);
            AddTax(prices[FIRST_PRICE]); // pass by value (copy of variable made)
            ShowPrices(prices);  // pass by reference (starting address for the data value is given to the method)
            Inflate(prices); // pass by reference
            ShowPrices(prices); // pass by reference

            Console.ReadLine();
        }

        static void ShowPrices(decimal[] price)
        {
            Console.WriteLine("Value in calling method: " + price[FIRST_PRICE].ToString("C"));
        }

        static void AddTax(decimal price)
        {
            const decimal TAX_RATE = 1.07m;
            price *= TAX_RATE;
            Console.WriteLine("After tax: " + price.ToString("C"));
        }

        static void Inflate(decimal[] prices)
        {
            const decimal INFLATION_RATE = 1.01m;
            prices[FIRST_PRICE] *= INFLATION_RATE;
            Console.WriteLine("After Inflation: " + prices[FIRST_PRICE].ToString("C"));
        }
    }
}
