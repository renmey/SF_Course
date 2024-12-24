using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateRealExample.States
{
    internal class LowerElevatorState : IElevatorState
    {
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Опускаемся еще нижу");
        }

        public void Up(Elevator elevator)
        {
            Console.WriteLine("Поднимаемся на первый этаж");
            elevator.ElevatorState = new GroundElevatorState();
        }
    }
}
