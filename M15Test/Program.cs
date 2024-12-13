using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M15Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] cars = new string[] { "Jeep", "Volga", "Gazel", "Kia" };
            string[] buses = { "Gazel", "LiAz", "Ikaruses" };

            var vehicles = buses.Concat(cars); 

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }

            Console.ReadKey();

        }
    }
}
