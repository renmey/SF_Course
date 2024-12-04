﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Contact
    {
        public String Name { get; }
        public String LastName { get; }
        public long PhoneNumber { get; }
        public String Email { get; }

        public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }


    }
}