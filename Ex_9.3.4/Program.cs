using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9._3._4
{
    internal class Program
    {

        public delegate void CalculateDelegate(int x, int y);


        static void Main(string[] args)
        {
            //CalculateDelegate calculateDelegate = Sub;

            //calculateDelegate += Sum;

            //calculateDelegate.Invoke(30, 20);

            //Console.ReadKey();  

            Func<int, int, int> Addition = AddNumbers;

            int result = Addition.Invoke(5, 7);
            Console.WriteLine(result);


            Console.ReadKey();  


        }

        private static int AddNumbers(int param1, int param2)
        {
            return param1 + param2;
        }

        public static void Sum(int x, int y)
        {

           Console.WriteLine(x + y);
        }

        public static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
    }
}
