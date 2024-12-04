using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14.p2.c1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };

            var wordsInfo = words.Select(word =>
            new
            {   Name = word,
                Length = word.Length,
            }).OrderBy(word => word.Length);

            foreach (var word in wordsInfo)
            {
                Console.WriteLine(word.Name + ", Длина слова: " + word.Length);
            }

            Console.ReadKey();

        }
    }
}
