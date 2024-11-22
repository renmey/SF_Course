using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M13.HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Users\deadb\OneDrive\Рабочий стол\SFDirectory";
            string fileName = "HW_Module13.txt";
            string filePath = Path.Combine(folderPath, fileName);

            string text = File.ReadAllText(filePath);
            var noPunctuationText = new string(text.Where( c  => !char.IsPunctuation(c) ).ToArray());
            
            //Заносим все слова в массив
            string[] words = noPunctuationText.Split(' ');

           
           //Словарь для подсчета слов, ключом является слово, а значение - число повторений его в в массиве words
          Dictionary<string, int> map = new Dictionary<string, int>();

            //Значение увеличивается на 1 каждый раз как ключевое слово  встрчается в тексте
            foreach (var word in words)
            {
                if (map.ContainsKey(word))
                {
                    map[word]++;
                }
                else
                {
                    map.Add(word, 1);
                }
            }

            var topWords = map.OrderByDescending(c => c.Value).Take(10);

            foreach (var word in topWords)
            {
                Console.WriteLine(word.Key + ": " + word.Value);
            }


            Console.ReadKey();  

        }
    }
}
