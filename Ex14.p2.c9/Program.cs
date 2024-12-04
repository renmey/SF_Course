using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.p2.c9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Подготовка данных
            var cars = new List<Car>()
{
   new Car("Suzuki", "JP"),
   new Car("Toyota", "JP"),
   new Car("Opel", "DE"),
   new Car("Kamaz", "RUS"),
   new Car("Lada", "RUS"),
   new Car("Lada", "RUS"),
   new Car("Honda", "JP"),
};


            var notJapanCars = cars.Where(car => car.CountryCode != "JP");

            foreach (var notJapanCar in notJapanCars)
                Console.WriteLine(notJapanCar.Manufacturer);

            Console.WriteLine();

         Console.ReadKey();
        }
    }
}
