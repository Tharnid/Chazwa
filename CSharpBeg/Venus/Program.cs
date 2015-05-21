using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venus
{
    class Program
    {
        static void Main(string[] args)
        {
            int venusMoonCount = 0;
            float windSpeed = 450.0f;
            string venusFact = "Venus is the only planet " + "that rotates clockwise.";

            // display the variables
            Console.WriteLine(venusFact);
            Console.Write("Total Moons = ");
            Console.WriteLine(venusMoonCount);

            Console.Write("Venusian windspeed = ");

            Console.WriteLine(windSpeed + " miles/hr");

            Console.ReadLine();
        }
    }
}

// Explicit Variable Conversion
// float distance = -386.8f;
// int distanceInMiles = (int)distance; // Stores -386

// Implicit Variable Conversion