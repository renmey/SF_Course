using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Определяем путь к папке для параметра метода
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string directoryPath = Path.Combine(desktopPath, "SFDirectory");



            //Переменная для времени неиспользования файла или папки
            TimeSpan fileAgeLimit = TimeSpan.FromMinutes(1);

            //Переменная для текущео времени
            DateTime currentTime = DateTime.Now;

            // Проверяем существование директории
            if (Directory.Exists(directoryPath))
            {

                try
                {
                    double folderSize = GetDirectorySize(directoryPath);
                    Console.WriteLine($"Исходный размер папки: {folderSize} байт.");

                    // Счетчик удаленных файлов
                    int deletedFilesCount = 0;

                    CleanDirectory(directoryPath, currentTime, fileAgeLimit, ref  deletedFilesCount);
                    Console.WriteLine($"Удалено файлов: {deletedFilesCount}");
                    

                    double newfolderSize = GetDirectorySize(directoryPath);
                    Console.WriteLine($"Освобождено: {folderSize - newfolderSize} байт");
                    Console.WriteLine($"Текущий размер папки: {newfolderSize} байт.");
                    



                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            else
            {
                Console.WriteLine("Папка не существует.");
            }


            Console.ReadKey();
        }

        public static double GetDirectorySize(string directoryPath)
        {

            double size = 0;
            foreach (string file in Directory.GetFiles(directoryPath))
            {
                size += new FileInfo(file).Length;
            }

            // Рекурсивно добавляем размер файлов из вложенных директорий
            foreach (string directory in Directory.GetDirectories(directoryPath))
            {
                size += GetDirectorySize(directory);
            }

            return size;
        }


        public static void CleanDirectory(string directory, DateTime currentTime, TimeSpan fileAgeLimit, ref int deletedFilesCount)
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
                        deletedFilesCount++; // Увеличиваем счетчик удаленных файлов
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
                CleanDirectory(subDirectory, currentTime, fileAgeLimit, ref deletedFilesCount  );

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
