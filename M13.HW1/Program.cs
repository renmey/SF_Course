using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace M13.HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string folderPath = @"C:\Users\deadb\OneDrive\Рабочий стол\SFDirectory";
            string fileName = "HW_Module13.txt";
            string filePath = Path.Combine(folderPath, fileName);

            List<string> list = new List<string>(File.ReadLines(filePath));
            LinkedList<string> linkedList = new LinkedList<string>(File.ReadLines(filePath));

            var watch = new Stopwatch();


            //Вставка в конец
            watch.Start();
            list.Add("Some Word");
            watch.Stop();
            Console.WriteLine("Вставка в конец List " + watch.Elapsed.TotalMilliseconds + " мс");

            watch.Start();
            linkedList.AddLast("Some Word");
            watch.Stop();
            Console.WriteLine("Вставка в конец Linked List " + watch.Elapsed.TotalMilliseconds + " мс");



            //Вставка в середину
            int midIndex = list.Count /2 ;
            watch.Start();
            list.Insert(midIndex, "Some Word");
            watch.Stop();
            Console.WriteLine("Вставка в середину List " + watch.Elapsed.TotalMilliseconds + " мс");

            //Находим середину связанного списка
            LinkedListNode<string> currentNode = linkedList.First;
            for (int i = 0; i < midIndex; i++)
            {
                currentNode = currentNode.Next;
            }


            watch.Start() ;
            linkedList.AddAfter(currentNode, "Some Word");
            watch.Stop();
            Console.WriteLine("Вставка в середину Linked List " + watch.Elapsed.TotalMilliseconds + " мс");


            
            Console.ReadKey();
        }
    }
}
