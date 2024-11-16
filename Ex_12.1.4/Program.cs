using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите свой возраст");

            int age = Int32.Parse(Console.ReadLine());

            if (age > 13)
            {

                Console.WriteLine("Вы успешно авторизовались");

            }
            else
            {
                Console.WriteLine(",,,,,,,");
            }

            Console.ReadKey();  

        }
    }
}
