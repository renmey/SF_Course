﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Car<T>
    {
        T EngineType;

        public Car(T EngineType) { }
    }
}
