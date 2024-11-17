using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12.c1.p5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User
            {
                Login = "1person",
                Name = "Jake",
                IsPremium = true,
            };

            User user2 = new User
            {
                Login = "2person",
                Name = "Mary",
                IsPremium = false
            };

            user1.Greetings();
            user2.Greetings();

            Console.ReadKey();  
        }
    }
}
