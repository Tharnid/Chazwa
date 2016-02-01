using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price = 1234.56m;
            string concatenated = "$" + price;
            string formatted = string.Format("{0:C}", price);
            string interpolated = $"{price:C}";

            // This gives us the price formatted as a currency using the default currency
            // provided by the operating system. What if we want to use the currency of
            // Great Britain regardless of where in the world the machine is?
 
            // Note that we added "using System.Globalization;"
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");
            NumberFormatInfo format = culture.NumberFormat;

            string customFormatted = price.ToString("C", format);

            // We can change the number format by setting 
            // its properties.

            format.CurrencyGroupSeparator = " ";
            string withSpace = price.ToString("C", format);

            Console.WriteLine(customFormatted);
            Console.ReadLine();
        }
    }
}
