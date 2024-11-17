using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex12.c1.p5
{
    internal class User
    {

        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

       

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
