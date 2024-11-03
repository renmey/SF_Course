using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10._2._2
{

    public interface IWriter
    {
        void Write();
    }

    class Writer : IWriter
    {
        void IWriter.Write()
        {
            Console.WriteLine("Hello World");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            Writer writer = new Writer();

            (writer as IWriter).Write();

            ((IWriter)writer).Write();

            Console.ReadKey();
        }
    }
}
