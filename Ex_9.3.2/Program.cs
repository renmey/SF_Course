using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_9._3._2
{
    internal class Program
    {

        public delegate int MyDelegate(int x, int y);

        static void Main(string[] args)
        {

            MyDelegate myDelegate = Sub;
            int result = myDelegate.Invoke(5, 2);

            Console.WriteLine(result);

            Console.ReadKey();




        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }
    }
}