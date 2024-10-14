using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_6._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            TrafficLight trafficLight = new TrafficLight("red");
            Console.WriteLine(trafficLight.GetColor());


            trafficLight.ChangeColor("green");
            Console.WriteLine(trafficLight.GetColor());



            Console.ReadKey();
        }
    }


    public class TrafficLight
    {
        private string color;

        public TrafficLight(string color)
        {
            this.color = color;
        }

         public void ChangeColor(string color)
        {
            this.color = color;

        }


        

        public string GetColor()
            { return this.color; 
        }


    }
}
