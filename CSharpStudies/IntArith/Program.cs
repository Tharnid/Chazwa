using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntArith
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            i = 30 - 10 + 20 * 4;

            int h;

            h = 23 / 2;

            // unary negative

            int g;

            g = -23 / 4;

            // remainder gives what is left

            int j;
            int k;

            j = 23 % 4;
            k = -23 % 4;

            bool l = 23 < 4;

            //string x;
            //string y;

            //x < y; less than 
            //x < y; greater than
            //x <= y; less than equals to
            //x >= y; greater than equal to
            //x == y; equal
            //x != y; NotEqual

            Console.WriteLine(l);
            Console.WriteLine(i);
            Console.WriteLine(h);
            Console.WriteLine(g);
            Console.WriteLine(j);
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
