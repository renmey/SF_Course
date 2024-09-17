using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4._3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");

            string name = Console.ReadLine();

            for (int i = name.Length - 1; i >= 0; i--)
            {

                Console.Write(name[i] + " ");
            }

            Console.ReadKey();
        }
    }
}

