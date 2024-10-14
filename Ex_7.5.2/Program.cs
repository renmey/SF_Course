using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7._5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter.increasingCounter = 100;

            Counter.increasingCounter = 90;

            Console.WriteLine(Counter.IncreasingCounter);

            Console.ReadKey();

        }
    }


    public class Obj
    {
        public String Name;
        public String Description;
        public static int MaxValue = 2000;


    }

    class Counter
    {
        public static int increasingCounter;

        public static int IncreasingCounter
        {
            get
            {
                return increasingCounter;
            }

            set
            {
                if (value > increasingCounter)
                {
                    IncreasingCounter = value;
                }
            }
        }
    }
}
