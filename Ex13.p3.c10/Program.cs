using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.p3.c10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string sentence = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, " +
                "учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";


            char[] chars = sentence.ToCharArray();

            HashSet<char> set = new HashSet<char>();

            foreach (char c in chars)
            {

                set.Add(c);
            }

            Console.WriteLine(set.Count);

            Console.ReadKey();  


        }
    }
}
