using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Module_7._1._10
{


    class BaseClass
    {
        protected string Name;

        public BaseClass(string name) {
            Name = name;
        }


        class DerivedClass: BaseClass {

            public string Description;

            public int Counter;

            public DerivedClass(string name, string description) : base(name)
            {

                Description = description;
            }

            public DerivedClass(int counter, string name, string description): this (name, description) {    
                Counter = counter;
            }
            `


        }





    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
