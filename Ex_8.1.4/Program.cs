using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;

namespace Ex_8._1._4
{

    public class Drive
    {
        string Name { get; }
        long TotalSpace { get; }
        long FreeSpace { get; }

        public Drive(string name, long totalSpace, long freeSpace)
        {
            this.Name = name;
            this.TotalSpace = totalSpace;
            this.FreeSpace = freeSpace;

        }

        public class Folder
        {
            public List<string> Files { get; set; } = new List<string>();

            public Dictionary<string, Folder> Folders { get; set; } = new Dictionary<string, Folder>();

            public void CreateFolder(string name)
            {
                Folders.Add(name, new Folder());
            }

        }





        internal class Program
        {
            static void Main(string[] args)
            {
                // получим системные диски
                DriveInfo[] drives = DriveInfo.GetDrives();

                // Пробежимся по дискам и выведем их свойства
                foreach (DriveInfo drive in drives)
                {
                    Console.WriteLine($"Название: {drive.Name}");
                    Console.WriteLine($"Тип: {drive.DriveType}");
                    if (drive.IsReady)
                    {
                        Console.WriteLine($"Объем: {drive.TotalSize}");
                        Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                        Console.WriteLine($"Метка: {drive.VolumeLabel}");
                    }
                }

                Console.ReadKey (); 

            }

        }
    }
}