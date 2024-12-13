using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupByTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
            {
               new Car("Suzuki", "JP"),
               new Car("Toyota", "JP"),
               new Car("Opel", "DE"),
               new Car("Kamaz", "RUS"),
               new Car("Lada", "RUS"),
               new Car("Honda", "JP"),
            };


            var carsByCountry = cars.GroupBy(car => car.CountryCode);

            var carsByCountry2 = from car in cars
                                 group car by car.CountryCode into grouping
                                 select new
                                 {
                                     Name = grouping.Key,
                                     Count = grouping.Count(),
                                     Cars = from p in grouping select p
                                 };

            foreach (var group in carsByCountry2)
            {
                Console.WriteLine($"{group.Name} : {group.Count} авто");
                

                foreach (var car in group.Cars)
                {
                    Console.WriteLine(car.Manufacturer);
                }

                Console.WriteLine();
            }



            Console.ReadKey();  


        }
    }
}
