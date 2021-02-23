using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet planet = new Planet();

            List<string> Planets = planet.GetPlanetNames();

            int Count = 0;
            
            // Loop through the Planets list
            foreach(string item in Planets)
            {
                Count++;
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPlanets count: " + Count);

            // Remove planets
            planet.RemovePlanets();

            Console.ReadKey();
        }
    }
}
