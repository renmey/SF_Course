using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (string name, int age, string[] favcolors) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);

            Console.WriteLine("Введите ваши любимые цвета нажимая пробел");
            anketa.favcolors = new string[3];

            for (int i = 0; i < anketa.favcolors.Length; i++)
            {
                anketa.favcolors[i] = Console.ReadLine();
            }

            Console.WriteLine("Ваши любимые цвета:");
            foreach (string color in anketa.favcolors)
            {

                ShowColor(color);
            }
            

            Console.ReadKey();
        }


        static void ShowColor(string color)
        {
            switch (color)
            {

                case "red":

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                default:

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }


                    Console.WriteLine($"Your color is {color}!");
            }



        }

    }

