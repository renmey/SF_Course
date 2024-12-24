using FacadeRealExample.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeRealExample
{
    internal class IdeFacade
    {
        readonly Editor _editor;
        readonly Compiller _compiler;
        readonly RunTime _runTime;

        public IdeFacade(Editor editor, Compiller compiler, RunTime runTime)
        {
            _editor = editor;   
            _compiler = compiler;
            _runTime = runTime;
        }

        // Вы ввели код, IDE выполняет с ним примерно следующие действия перед запуском:

        public void Start(string sourceCode)
        {
            // Пишет в текстовый файл
            _editor.Write(sourceCode);

            // Сохраняет текстовый файл
            _editor.Save();

            // Вызывает компилятор
            _compiler.Compile();

            // Запускает выполнение скомпилированного приложения в среде CLR
            _runTime.Execute();
        }

        // в конце IDE может остановить выполнение, вызвав команду в среде выполнения
        public void Stop()
        {
            _runTime.Finish();
        }

    }
}
