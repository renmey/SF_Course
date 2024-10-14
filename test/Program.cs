using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    


    internal class Program
    {
        public struct Data
        {
            public int id;
            public string name;

            public Data (int id, string name)
            {
                this.id = id;

            this.name = name;
            }
        }

        public class Obj
        {
            public string name;
           public bool isAlive;

            public Obj(string name, bool isAlive)
            {
                this.name = name;
                this.isAlive = isAlive;
            }
        }



        static void Main(string[] args)
        {

            Obj obj = new Obj("Кошка", true);
            Data data = new Data(4, "emp");

            var objCopy = obj;
            var dataCopy = data;

            Console.WriteLine(obj.name);
            Console.WriteLine(data.name + " " + data.id);

            obj.name = "Dog";
            data.name = "ret";
            data.id = 45;

            Console.WriteLine(obj.name);
            Console.WriteLine(data.name + " " + data.id);

            Console.WriteLine("________________________________");

            Console.WriteLine(objCopy.name);
            Console.WriteLine(dataCopy.name + " " + dataCopy.id);



            Console.ReadKey();
        }

        
    }
}
