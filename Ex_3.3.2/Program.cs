using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_3._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "Vlad";
            byte Age = 31;
            Boolean DoIHaveAPet = true;
            float ShoeSize = 44;

            Console.WriteLine($"My name is {Name}\nI am {Age} old\nDo i have a pet? {DoIHaveAPet}\nMy shoes size is {ShoeSize} " );
            Console.ReadKey();
        }
    }
}
