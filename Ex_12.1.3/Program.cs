using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько элементов будет в массиве?");

            int count = Int32.Parse(Console.ReadLine());

            string[] array = new string[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = Console.ReadLine();
            }

            Console.WriteLine("Все элементы записаны");

            array.ToList().ForEach(x => Console.Write(x + " "));

            Console.ReadKey();

        }
    }
}
