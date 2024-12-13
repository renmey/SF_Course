using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15.p2.c2
{
    public class Contact
    {
        public string Name { get; set; }
        public long Phone { get; set; }


    internal class Program
    {
            static void Main(string[] args)
            {

                var contacts = new List<Contact>()
{
               new Contact() { Name = "Андрей", Phone = 79994500508 },
               new Contact() { Name = "Сергей", Phone = 799990455 },
               new Contact() { Name = "Иван", Phone = 79999675334 },
               new Contact() { Name = "Игорь", Phone = 8884994 },
               new Contact() { Name = "Анна", Phone = 665565656 },
               new Contact() { Name = "Василий", Phone = 3434 }
};
                var invalidNumbers = ( from contact in contacts
                                      let phoneString = contact.Phone.ToString()
                                      where phoneString.Length !=11 && !phoneString.StartsWith("7")
                                      select contact).Count();

                Console.WriteLine(invalidNumbers);

                Console.ReadKey();




            }

            

        }
    }
}
