using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhateverArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] employees = { "John", "Paul", "George", "Ringo" };

            foreach (string employee in employees)
            {

                Console.WriteLine("Employee:" + employee); // print employee
                Console.ReadLine();
            }
        }
    }
}
