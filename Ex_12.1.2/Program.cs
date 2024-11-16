using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();

            string greetings = $"Привет {name}";

            Console.WriteLine(greetings);
            Console.ReadKey();  


        }
    }
}
