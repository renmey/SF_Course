using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fin_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            byte age = checked((byte)int.Parse(Console.ReadLine()));

            Console.WriteLine("Введите ваш день, месяц и год рождения");
            byte dayOfBirth = byte.Parse(Console.ReadLine());
            byte monthOfBirth = byte.Parse(Console.ReadLine());
            int yearOfBirth = int.Parse(Console.ReadLine());


            Console.WriteLine($"Ваше имя: {name} \n" +
                $"Ваш возраст: {age} \n" +
                $"Ваша дата рождения: {dayOfBirth}.{monthOfBirth}.{yearOfBirth}");

            
            Console.ReadKey();
            

        }
    }
}
