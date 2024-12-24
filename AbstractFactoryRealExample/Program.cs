using AbstractFactoryRealExample.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryRealExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Monster dragon = new Monster(new DragonFactory());
            dragon.Hit();
            dragon.Move();

            Console.WriteLine();

            Monster Orc = new Monster(new OrcFactory());
            Orc.Hit();
            Orc.Move();


            Console.ReadKey();  

        }
    }
}
