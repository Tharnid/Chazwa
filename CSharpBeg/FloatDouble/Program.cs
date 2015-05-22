using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            double b;

            a = 3.0F / 7.0F;
            b = 3.0 / 7.0;

            Console.WriteLine("Float value of 3.0 / 7.0 expression is {0} and double value is {1}", a, b);
            Console.ReadLine();
        }
    }
}
