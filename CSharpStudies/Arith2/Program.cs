using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arith2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool m;

            m = 30 - 10 + 20 * 4 > 100 - 1;

            // Floating Values

            // Decimal literals must end in m
            decimal dollars = 123.45m;

            // double literals typically do not
            double width = 240.0d;
            double length = 156.7;
            double huge = 1.235689e13;

            // Mixing integers with dobules or decimals is fine
            double triangleArea = width * length / 2;

            // Can't mix decimals with doubles
            //decimal pricePerMeter = width * length;



            // Type cast tells c# that you really want to mix them, and how:

            decimal pricePerMeter = dollars / (decimal)length;

            double oneTenth = 0.1;
            double one = oneTenth + oneTenth + oneTenth + oneTenth + oneTenth + oneTenth + oneTenth + oneTenth + oneTenth + oneTenth;

            decimal oneThird = 1.0m / 3.0m;

            Console.WriteLine(oneThird + oneThird + oneThird);

            Console.WriteLine(m);
            Console.WriteLine(triangleArea);
            Console.WriteLine(pricePerMeter);
            Console.WriteLine(1.0 == one);
            Console.ReadLine();
        }
    }
}