using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Определяем путь к папке для параметра метода
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string directoryPath = Path.Combine(desktopPath, "SFDirectory");

            // Проверяем существование директории
            if (Directory.Exists(directoryPath))
            {

                try
                {
                    double folderSize = GetDirectorySize(directoryPath);
                    Console.WriteLine($"Размер папки: {folderSize} байт.");
                } catch (Exception ex) { Console.WriteLine(ex.Message ); }
            }
            else
            {
                Console.WriteLine("Папка не существует.");
            }


            Console.ReadKey();  
        }

        static double GetDirectorySize(string directoryPath)
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


    }
    
}

