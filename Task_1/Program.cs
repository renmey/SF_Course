using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exception = new Exception[5];

            exception[0] = new MyException("Мое собственное исключение");
            exception[1] = new DivideByZeroException("Деление на ноль");
            exception[2] = new OutOfMemoryException("Не хватает памяти");
            exception[3] = new IndexOutOfRangeException("Выход за границы массива");
            exception[4] = new ArgumentNullException();


            foreach (Exception ex in exception)
            {
                try
                {
                    throw ex;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Поймано исключение:{ex.Message}" );
                }
                finally { Console.WriteLine("----------------------"); }

            }

            Console.ReadKey();  
        }
    }
}
