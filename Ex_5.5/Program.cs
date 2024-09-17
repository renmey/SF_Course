using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5._5._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите слово");

            string world = Console.ReadLine();

            Echo(world, 5);

            Console.ReadKey();
        }



        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }


            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("... " + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }


    }
}
