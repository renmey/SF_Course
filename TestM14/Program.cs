using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestM14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var objects = new List<object>()
            {
                   1,
                   "Сергей ",
                   "Андрей ",
                   300,
                };


            var names = objects.Where(n => n is string).OrderBy(n => n);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();  

        }
    }
}
