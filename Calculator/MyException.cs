using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MyException: Exception
    {
        ILogger Logger { get; }


        public MyException(ILogger Logger) {

            this.Logger = Logger;
            Logger.Error("Ошибка ввода");
        }
    }
}
