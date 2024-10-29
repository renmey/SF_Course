using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string directoryPath = Path.Combine(desktopPath, "SFDirectory");

            Console.WriteLine($"Путь к папке Directory на рабочем столе: {directoryPath}");


            if (Directory.Exists(directoryPath))
            {
                Console.WriteLine("Папка существует.");
            }
            else
            {
                Console.WriteLine("Папка не найдена.");
            }

            //Переменная для времени неиспользования файла или папки
            TimeSpan fileAgeLimit = TimeSpan.FromMinutes(30);

            //Переменная для текущео времени
            DateTime currentTime = DateTime.Now;



            try
            {
                
                Clean.CleanDirectory(directoryPath, currentTime, fileAgeLimit);
                Console.WriteLine("Очистка завершена.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }


            Console.ReadKey();
        }



         
        }


    
}



