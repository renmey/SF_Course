using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_12._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User("person1", "Jake", true);
            User user2 = new User("person2", "Mary", false);

            user1.Greetings();
            user2.Greetings();


            Console.ReadKey();  

        }
    }
}
