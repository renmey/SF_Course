using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class Program
    {
        public delegate int SumDelegate(int a, int b, int c);

        static void Main(string[] args)
        {
            SumDelegate sumDelegate = Sum;
            int result = sumDelegate.Invoke(1, 2, 3);


            
            Console.WriteLine(result);
            Console.ReadKey();


            
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
