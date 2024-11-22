using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13.p3.c4
{
    internal class Contact
    {
        public Contact(string name, long phoneNumber, String email) // метод-конструктор
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public String Name { get; }
        public long PhoneNumber { get; }
        public String Email { get; }


        public void AddUnique(Contact newContact, List<Contact> phoneBook)
        {
            bool AlreadyExists = false;

            foreach (Contact contact in phoneBook)
            {
                if (contact.Name == newContact.Name || contact.PhoneNumber == newContact.PhoneNumber)
                {
                    AlreadyExists = true;

                    break;
                }
            }
            if (!AlreadyExists)
                phoneBook.Add(newContact);


            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

        }
    }
        }
    
