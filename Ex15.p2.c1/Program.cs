using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.p2.c1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(10));

            Console.ReadKey();  
        }


        static long Factorial(int n)
        {
            var numbers = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                numbers.Add(i);
            }

            long result = numbers.Aggregate((x,y) => x * y);

                return result;
        }
    }
}
