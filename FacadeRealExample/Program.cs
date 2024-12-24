using FacadeRealExample.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRealExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // при запуске IDE инициализирует объекты для работы с компонентами
            Editor textEditor = new Editor();
            Compiller compiller = new Compiller();
            RunTime runtime = new RunTime();

            // Наша модель IDE запущена и готова к использованию
            IdeFacade ide = new IdeFacade(textEditor, compiller, runtime);

            // Начинаем писать код и нажимаем кнопку Start
            ide.Start("Console.WriteLine(\"Hello World!\");"); // запускается выполнение нашей программы
            ide.Stop();


            Console.ReadKey();  

        }
    }
}
