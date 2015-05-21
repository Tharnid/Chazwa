using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Program
    {

        const int FIRST = 1;

        enum Planet
        {
            Jupiter = FIRST, Saturn, Uranus, Neptune, Earth, Venus, Mars, Mecury, Pluto
        };

        static void Main(string[] args)
        {
            // Store the planet names
            string[] planetNames = Enum.GetNames(typeof(Planet));
            Console.WriteLine("Total planets: " + planetNames.Length);

            // Display size ranking for earth
            Console.WriteLine("Earth size rank = " + (int)Planet.Earth);

            // Show planet names associated with the top size ranking
            Planet planetName = (Planet)FIRST;

            Console.WriteLine("The largest planet is " + planetName.ToString() + "!!!");

            Console.ReadLine();
        }
    }
}
