using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4._4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (string Name, string Type, double Age, int NameCount) Pet;

            Console.WriteLine("Введите имя питомца:");
            Pet.Name = Console.ReadLine();

            Console.WriteLine("Введите тип питомца:");

            Pet.Type = Console.ReadLine();

            Console.WriteLine("Введите возраст животного:");
            Pet.Age = Double.Parse(Console.ReadLine());

            Console.WriteLine($"У вас {Pet.Type} с именем {Pet.Name}, возраст {Pet.Age} года");
            Console.ReadKey();
        }
    }
}
