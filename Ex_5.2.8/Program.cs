using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5._2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите размер массива");
           // int lengthOfArray = int.Parse(Console.ReadLine());


            

           SortArray(GetArrayFromConsole());

            Console.ReadKey();

        }

        static int[] GetArrayFromConsole(int lengthOfArray=5)
        {
            int[] array = new int[lengthOfArray];
            Console.WriteLine("Введите массив");
            

            for (int i = 0; i < array.Length; i++) {

                array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Полученный массив");
            foreach(var item in array)
                Console.Write(item + " ");

            return array;
        }

        static void SortArray(int[] array)
        {

            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine("\nОтсортированный массив");
            foreach(var item in array)
                Console.Write(item + " ");
        }


    }
}
