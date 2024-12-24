using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonRealExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application application = new Application();

            application.Launch("10.43.21.213");
            Console.WriteLine(application.DbConnection.Configuration);

            application.DbConnection = DbConnection.GetConnectionInstance("10.30.60.81");
            // у нас не получилось, так как объект уже существует
            Console.WriteLine(application.DbConnection.Configuration);

            Console.ReadKey();  

        }
    }
}
