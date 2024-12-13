using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>()
{
               new Car() { Model  = "SX4", Manufacturer = "Suzuki"},
               new Car() { Model  = "Grand Vitara", Manufacturer = "Suzuki"},
               new Car() { Model  = "Jimny", Manufacturer = "Suzuki"},
               new Car() { Model  = "Land Cruiser Prado", Manufacturer = "Toyota"},
               new Car() { Model  = "Camry", Manufacturer = "Toyota"},
               new Car() { Model  = "Polo", Manufacturer = "Volkswagen"},
               new Car() { Model  = "Passat", Manufacturer = "Volkswagen"},
            };

            var manufacturers = new List<Manufacturer>()
{
               new Manufacturer() { Country = "Japan", Name = "Suzuki" },
               new Manufacturer() { Country = "Japan", Name = "Toyota" },
               new Manufacturer() { Country = "Germany", Name = "Volkswagen" },
            };

            var result = from car in cars
                         join m in manufacturers on car.Manufacturer equals m.Name

                         select new
                         {
                             Name = car.Model,
                             Manufacturer = m.Name,
                             Country = m.Country,
                         };

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} - {item.Manufacturer} ({item.Country})");
            }

            Console.ReadKey();  


        }
    }
}
