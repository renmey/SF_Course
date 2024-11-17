using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 23, 45, 223, 432 };

           

            Console.WriteLine(BinarySearch(23, ints, 0, 5));

            Console.ReadKey();
        }

        static int BinarySearch(int value, int[] array, int left, int right)
        {
            while (left <= right)
            {
                var middle = (left + right) / 2;

                var midElement = array[middle];

                if (midElement == value)
                {
                    return middle;
                }
                else if (value < midElement)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }

    }


}
