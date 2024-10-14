using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7._2._5
{


    abstract class FourLeggedAnimal
    {
        public abstract string Name
        {
            get;
            set;
        }
    }

    class Dog : FourLeggedAnimal
    {
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }

    class Cat : FourLeggedAnimal
    {
        public override string Name
        {
            get;
            set;
        }
    }
   



    internal class Program
    {
        static void Main(string[] args)
        {

          Dog dog = new Dog();

            dog.Name = " gertt";

           

            

            Console.ReadKey();  
        }
    }
}
