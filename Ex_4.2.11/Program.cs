using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_4._2._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = 0;

            do
            {
                Console.WriteLine("t = " + t);
                Console.WriteLine("Напишите свой любимый цвет");

                switch (Console.ReadLine())
                {

                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is green");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Your color is cyan");
                        break;

                        
                }
                t++;


            } while (t < 3);
            Console.ReadKey();
        }
    }
}
