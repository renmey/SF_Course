using AdapterRealExample.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterRealExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Нам надо отрисовать изображение на бумаге и холсте
            // Запускаем класс для отрисовки
            var imageDrawer = new ImageDrawer();

            // Создаем класс для работы с бумажным принтером
            PaperPrinter paperPrinter = new PaperPrinter();
            // Запускаем отрисовку на бумаге
            imageDrawer.DrawWith(paperPrinter);

            // Теперь нужна печать на холсте
            CanvasPainter canvasPainter = new CanvasPainter();

            // используем адаптер
            IPrinter imagePrinter  = new CanvasPainterToPrinterAdapter(canvasPainter);
            // используем адаптер
            imageDrawer.DrawWith(imagePrinter);


            Console.ReadKey ();



        }
    }
}
