using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;

            for (int i = 0; i < 3; i++)
            {


                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;
                Console.WriteLine($"Длина логина пользователя составляет {User.LoginLength} знаков");

                User.HasPet = false;
                Console.WriteLine("Есть ли у вас животные? Да или Нет");
                if (Console.ReadLine().ToLower() == "да")
                {
                    User.HasPet = true;
                }

                Console.WriteLine("Введите возраст пользователя");
                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];


                Console.WriteLine("Введите три любимых цвета пользователя");
                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }

                i++;
            }
        
            

            Console.ReadKey();

        }
    }
}
