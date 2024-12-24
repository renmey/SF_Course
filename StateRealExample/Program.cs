using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StateRealExample.States;

namespace StateRealExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator(new GroundElevatorState());


            elevator.Up();
            elevator.Down();
            elevator.Down();
            
            Console.ReadKey();  

        }
    }
}
