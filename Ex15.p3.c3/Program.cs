﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.p3.c3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));


            var groped = phoneBook.GroupBy(c => c.Email.Split('@').Last()); 

            foreach (var group in groped) {
                if(group.Key.Contains("example"))
                { 
                    Console.WriteLine("Фейковые адреса");
                foreach (var contact in group)
                    Console.WriteLine(contact.Name + " " + contact.Email);

            }
                        else
            {
                Console.WriteLine("Реальные адреса: ");
                foreach (var contact in group)
                    Console.WriteLine(contact.Name + " " + contact.Email);
            }

            Console.WriteLine();
        }

            Console.ReadKey();


    }
    }
}
