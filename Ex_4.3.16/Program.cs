using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4._3._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int temp = 0;

            foreach (var num in arr)
            {

               

                    if (num > 0)
                    {
                        temp++;
                    }

                
            }
            Console.WriteLine(temp);
            Console.ReadKey();

        }
    }
}
