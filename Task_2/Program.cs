
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        // Сортировка А-Я
        static void Sort(string[] names)
        {
            Array.Sort(names);
        }

        // Сортировка Я-А
        static void ReverseSort(string[] names)
        {
            Array.Sort(names);
            Array.Reverse(names);  // Переворачиваем отсортированный массив
        }

        // Определяем делегат и событие
        public delegate void SortEvent(string[] names);
        public static event SortEvent OnSort;

        static void Main(string[] args)
        {

            string[] names = { "Павлов", "Бунин", "Менделеев", "Шишкин", "Обломов" };

            Console.WriteLine("Список до сортипровки: ");
            foreach (string name in names)
                Console.WriteLine(name);

            Console.WriteLine("Введите 1 для сортировки А-Я или 2 для сортировки Я-А:");

            try
            {
                int input = int.Parse(Console.ReadLine() );

                if (input == 1)
                    OnSort += Sort;

              else  if (input == 2)
                    OnSort += ReverseSort;

                else throw new InvalidInputException("Введено некорректное значение ");

                // Вызываем событие для сортировки
                OnSort?.Invoke(names);

                Console.WriteLine("Список после сортировки: ");

                foreach (string name in names) 
                    Console.WriteLine(name);

            }
            catch (InvalidInputException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }


           Console.ReadKey();


        }
            

    }
    
}
