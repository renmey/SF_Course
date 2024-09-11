using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Semaphore.Red);
            Console.ReadKey();  
        }

        private enum Semaphore
        {
            Red = 100,
            Green = 200, 
            Blue = 300
        }
    }
}
