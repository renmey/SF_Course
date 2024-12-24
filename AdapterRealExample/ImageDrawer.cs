using AdapterRealExample.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterRealExample
{
    internal class ImageDrawer
    {

        public void DrawWith(IPrinter printer)
        {
            printer.Print();

        }
    }
}
