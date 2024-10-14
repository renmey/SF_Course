using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7._6._9
{

    abstract class Engine { }

    abstract class CarPart { }

    class ElectricEngine : Engine { }

    class GasEngine : Engine { }

    class Battery : CarPart { }

    class Differential  : CarPart{ }

    class Wheel : CarPart { }

    class Car<TEngine> where TEngine : Engine
    {
        public TEngine Engine;

        public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart
        {

        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
