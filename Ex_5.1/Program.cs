using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            (string Name, string[] Dishes) User;

            Console.WriteLine("Введите имя пользователя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите пять любимых блюд");

            User.Dishes = new string[5];

            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine("Любимое блюдо " + (i+ 1));
                User.Dishes[i] = Console.ReadLine();
                
            }

            foreach (string Dishes in User.Dishes)
                Console.Write(Dishes + ", ");

            Console.ReadKey();


        }
    }
}
