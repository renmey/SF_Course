using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.p1.c1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var russianCities = new List<City>();
            {
                russianCities.Add(new City("Москва", 11900000));
                russianCities.Add(new City("Санкт-Петербург", 4991000));
                russianCities.Add(new City("Волгоград", 1099000));
                russianCities.Add(new City("Казань", 1169000));
            }

            var bigCities = russianCities.Where(v => v.Name.Length < 10).OrderBy(v => v.Name.Length);

            foreach (var city in bigCities)
            {
                Console.WriteLine(city.Name);
            }

            Console.ReadKey();  
        }
    }
}
