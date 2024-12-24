using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterRealExample.Devices
{
    internal class CanvasPainter : IPainter
    {
        public void Paint()
        {
            Console.WriteLine("Рисуем на холсте");
        }
    }
}
