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


    public class Clean {
        // Метод для рекурсивной очистки папки
        public static void CleanDirectory(string directory, DateTime currentTime, TimeSpan fileAgeLimit)
        {
            // Очищаем файлы в папке
            foreach (string file in Directory.GetFiles(directory))
            {
                try
                {
                    DateTime lastAccessTime = File.GetLastAccessTime(file);

                    // Удаляем файл если он не использовался дольще отведенного времени
                    if (currentTime - lastAccessTime > fileAgeLimit)
                    {
                        File.Delete(file);
                        Console.WriteLine($"Файл {file} был удален.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при удалении файла {file}: {ex.Message}");
                }
            }

            // Рекурсивно проходим по подкаталогам
            foreach (string subDirectory in Directory.GetDirectories(directory))
            {
                CleanDirectory(subDirectory, currentTime, fileAgeLimit);

                // Удаляем папку, если она пуста
                if (Directory.GetFiles(subDirectory).Length == 0 && Directory.GetDirectories(subDirectory).Length == 0)
                {
                    try
                    {
                        Directory.Delete(subDirectory);
                        Console.WriteLine($"Папка {subDirectory} была удалена.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка при удалении папки {subDirectory}: {ex.Message}");
                    }
                }

            }
        }
    }
}



