using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Age = 41;
            employee.Salary = 90000.00;

            // objectReference.MethodName();

            // objectReference.FieldName;

            Employee emp2 = new Employee();

            emp2.Age = 24;
            emp2.Salary = 50000.00;

            // this is the current object
        }
    }
}
