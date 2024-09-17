using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4._3._17
{
    internal class Program
    {

        //Сортировка двумерного массива
        static void Main(string[] args)
        {

            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int temp;

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {

                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                
                    for (int k = j+1; k <= arr.GetUpperBound(1); k++)
                    
                        if (arr[i,j] > arr[i, k])
                        { 
                            temp = arr[i, k];
                            arr[i,k] = arr[i,j];
                            arr[i,j] = temp;
                        }

                    
            }
            foreach (var num in arr)
            {
                Console.Write(num+ " ");
            }
            Console.ReadKey();


        }
    }
}
