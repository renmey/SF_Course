using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRealExample.Components
{
    /// <summary>
    /// Класс для работы с текстовым редактором
    /// </summary>
    internal class Editor
    {

        public void Write(string sourceCode)
        {
            Console.WriteLine($"Пишем код: {sourceCode}");
        }

        public void Save()
        {
            Console.WriteLine("Сохраняем код");
        }

    }
}
