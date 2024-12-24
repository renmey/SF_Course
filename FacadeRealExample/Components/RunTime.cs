using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRealExample.Components
{
    internal class RunTime
    {

        public void Execute()
        {
            Console.WriteLine("Выполнение приложения");
        }

        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения");
        }

    }
}
