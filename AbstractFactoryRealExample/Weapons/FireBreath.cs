using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample.Weapons
{
    internal class FireBreath : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Дышим огнем");
        }
    }
}
