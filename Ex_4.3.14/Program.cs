using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4._3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] array = new int[3][];

            array[0] = new int[4] { 2, 4, 21, 3 };
            array[1] = new int[2] { 3, 5 };
            array[2] = new int[5] { 4, 7, 34, 23, 2 };

            foreach (var num in array)
            {
                foreach (var item in num)
                {

                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
