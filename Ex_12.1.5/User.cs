using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex_12._1._5
{
    internal class User
    {

        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User(string Login, string Name, bool IsPremium )
        {
            this.Login = Login; 
            this.Name = Name;
            this.IsPremium = IsPremium;
        }

        public void Greetings()
        {
            
            if (!this.IsPremium)
            {
                Ads.ShowAds();
            }
            
                Console.WriteLine($"Hello {this.Name}\n");
            Thread.Sleep(2000);
            


        }

    }
}
