using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCalculator
{
    internal class Calculator : ICalculatorr
    {

        ILogger Logger {  get;  }

        public Calculator(ILogger Logger) {

            this.Logger = Logger;
        }


        public double Add(double a, double b)
        {


            Logger.Event("Результат сложения: ");
           return a + b;
        }
    }
}
