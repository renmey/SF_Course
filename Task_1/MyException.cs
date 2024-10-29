using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{

   /// <summary>
   /// Класс в котором будет реализовано собственное исключение
   /// </summary>
    internal class MyException : Exception
    {
        public MyException(string message): base(message) 
        { }
    }
}
