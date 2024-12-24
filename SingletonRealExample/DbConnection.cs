using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonRealExample
{
    public class DbConnection
    {
        private static DbConnection Connection;

        public string Configuration {  get; private set; }

        protected DbConnection (string Configuration)
        {
            this.Configuration = Configuration;
        }

        public static DbConnection GetConnectionInstance(string dbServer)
        {
            if (Connection == null)
            {
                Connection = new DbConnection(dbServer);
            }
            return Connection;

        }

    }
}
