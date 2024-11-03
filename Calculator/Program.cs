using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MiniCalculator
{
    internal class Program

        
    {

        static ILogger Logger {  get; set; }    
        static void Main(string[] args)
        {
            Logger = new Logger();

            Calculator calculator = new Calculator(Logger);

            Console.WriteLine("Введите первое число");
            string a = Console.ReadLine();


            Console.WriteLine("Введите второе число");
            string b = Console.ReadLine();


           
            try
            {
                if ((!double.TryParse(a, out double d) || (!double.TryParse(b, out double c)))) {

                    throw new MyException(Logger);
                }




                Console.Write(calculator.Add(double.Parse(a), double.Parse(b)));
            }
            catch (MyException) {   }

            Console.ReadKey();  
        }
    }
}
