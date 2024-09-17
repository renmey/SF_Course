using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace M_5_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowUser(EnterUser());



            Console.ReadKey();



        }


        // Метод для демонстрации данных
        static void ShowUser((string Name, string LastName, int Age, string[] Pets, string[] FavColors) User)
        {
            Console.WriteLine($"\nИмя пользователя: {User.Name} {User.LastName}");
            Console.WriteLine($"Возраст пользователя: {User.Age}");

            if (User.Pets == null)
                Console.WriteLine("У  пользователя нет домашнмх животных");
            else
            {
                Console.WriteLine($"У пользователя {User.Pets.Length} питомца(-ев) с кличками: ");

                foreach (string name in User.Pets)
                {
                    Console.Write(name + " ");
                }

            }


            Console.WriteLine($"\nЛюбимые цвета пользователя {User.Name} {User.LastName}: ");
            foreach( string colors  in User.FavColors)
                Console.Write(colors + " ");


        }


        //Метод для ввода данных пользователя
        static (string Name, string LastName, int Age, string[] Pets, string[] FavColors) EnterUser()
        {
            (string Name, string LastName, int Age, string[] Pets, string[] FavColors) User;

            
            

            do
            {
                Console.WriteLine("Введите имя пользователя:");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию пользователя:");
                User.LastName = Console.ReadLine();

                if (CheckUserName(User.Name, User.LastName) == false)
                    Console.WriteLine("Введены некорректные данные, попробуйте снова\n");

            } while (!(CheckUserName(User.Name, User.LastName)));


            string age;
            int intage;
            
            do
            {
                Console.WriteLine("Введите возраст пользователя");
                age = Console.ReadLine();


            } while (CheckNum(age, out intage));
            User.Age = intage;


            Console.WriteLine("Есть ли у вас домашние животные?\n");
            if (Console.ReadLine().ToLower() == "да")
            {
                

                string numberOfPets;
                int intNumOfPets;

                do
                {

                    Console.WriteLine("Введите количество ваших питомцев");
                    numberOfPets = Console.ReadLine();

                    

                } while (CheckNum(numberOfPets, out intNumOfPets));
                 User.Pets = GetPetArray(intNumOfPets);

            } else User.Pets = null;



            

            string numOfCol;
            int intNumOfCol;
            do
            {

                Console.WriteLine("Введите количество любимых цветов");
                numOfCol = Console.ReadLine();



            } while (CheckNum(numOfCol, out intNumOfCol));

            User.FavColors = FavColors(intNumOfCol);







           


            return User;
        }



        //Проверка имени и фамилии
        static bool CheckUserName(string Name, string Lastname)
        {
            int NumericName;
            int NumericLastName;

            //Проверка на случай, если введена пустая строка
            if (Name == "" || Lastname == "") return false;

            //Проверка ввода имени, а не числа
            if ((int.TryParse(Name, out NumericName)) || (int.TryParse(Lastname, out NumericLastName))) return false;
            return true;

        }



        
        static bool CheckNum(string Number, out int CorrNumber)
        {

            if (int.TryParse(Number, out int intnum))
            {
                if (intnum > 0)
                {
                    CorrNumber = intnum;
                    return false;
                }
            }
            CorrNumber = 0;
            return true;
            

        }



        //Метод для ввода любимых цветов
        static string[] FavColors(int num)
        {
            string[] strings = new string[num];

            Console.WriteLine("Введите ваши любимые цвета");

            for (int i = 0; i < num; i++)
            {
                strings[i] = Console.ReadLine();
            }

            return strings;

        }


        //Метод для  ввода кличек питомцев
        static string[] GetPetArray(int num)
        {
            string[] arr = new string[num];

            Console.WriteLine("Введите клички ваших питомцев");

            for (int i = 0; i < num; i++)
            {

                arr[i] = Console.ReadLine();
            }

            return arr;

        }

    }

}