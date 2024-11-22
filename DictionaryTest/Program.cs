using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string[]> cities = new Dictionary<string, string[]>();

            cities.Add("Россия", new[] { "Санкт-Петербург", "Москва", "Краснодар" });
            cities.Add("Украина", new[] { "Киев", "Львов", "Одесса" });
            cities.Add("Беларусь", new[] { "Минск", "Бобруйск", "Могилев" });


            foreach (var citiesByCountry in cities)
            {

                Console.Write(citiesByCountry.Key + ": ");
                


                foreach (var city in citiesByCountry.Value)
                {
                    Console.Write(city + " ");
                    
                }
                Console.WriteLine();

            }

            Console.WriteLine();


            string[] russianCities = cities["Россия"];

            Console.WriteLine("Города России");

            foreach (var city in russianCities)
            {
                Console.Write(city + " ");
            }

            Console.ReadKey();  

        }
    }
}
