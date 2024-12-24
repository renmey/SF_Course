using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonRealExample
{
    public class Application
    {
        public DbConnection DbConnection { get; set; }

        public void Launch(string dbServer)
        {

            DbConnection = DbConnection.GetConnectionInstance(dbServer);
        }

    }
}
