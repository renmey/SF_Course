using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5._3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив");

            int[] array = new int[6];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Полученный массив");

            foreach (int i in array)
                Console.Write(i + " ");

            SortArray(array,out array, out array);

            Console.ReadKey();  


        }


        static void SortArray(in int[] array, out int[] sorted_asc, out int[] sorted_desc)
        {
           sorted_asc = SortArrayAsc(array);
            

            Console.WriteLine("\nОтсортированные массивы:");

            foreach(var item in sorted_asc)
                Console.Write(item + " ");

            Console.WriteLine();

            sorted_desc = SortArrayDesc(array);

            foreach (var item in sorted_desc)
                Console.Write(item + " ");


        }


        //Сортировка от меньшего к большему
        static int[] SortArrayAsc(int[] array)
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
            return array;
        }
        //Сортировка от большего к меньшему
        static int[] SortArrayDesc(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;


        }

    }
}
