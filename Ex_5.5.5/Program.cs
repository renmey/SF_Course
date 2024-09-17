using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5._5._5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, факториал которого вы хотите получить:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(x));   
            
            Console.ReadKey();  


        }

        static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

    }
}
