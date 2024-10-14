using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7._5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 58;

            Helper.Swap(ref a, ref b);

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadKey();  

        }
    }

    public class Helper
    {
        public static void Swap(ref int a,ref int b)
        {

            int temp = a;
            a = b;
            b = temp;
        }
    }
}
