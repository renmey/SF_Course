using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = 7;

            double X = 4.6;
            double Y = 34.6;


            bool Result = (A < B) || (X > Y);
            Console.WriteLine(Result);
            Console.ReadKey(); 

        }
    }
}
