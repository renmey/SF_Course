
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.p5.c4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Stack<string> words = new Stack<string>();

            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            string input = Console.ReadLine();



            while (input != null)
            {
                switch (input)
                {
                    //   если  команда pop - пробуем достать элемент
                    case "pop":
                        words.Pop();
                        break;
                    //   если  команда peek - пробуем  просмотреть элемент
                    case "peek":
                        words.Peek();
                        break;
                    default:
                        // если ни одна из команд не распознана - простов стек добавляем то что введено
                        words.Push(input);
                        break;
                }

            }

            Console.ReadKey();



        }
    }
}
