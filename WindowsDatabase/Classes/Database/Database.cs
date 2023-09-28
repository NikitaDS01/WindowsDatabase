using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDatabase.Classes.Database
{
    public class Database
    {
        private const string DATASOURCE = @"DBSRV\ita2022";
        private const string INITIALCATALOG = @"007а2_DoroshenkoNS";

        public static string ConnectionString
        {
            get
            {
                return $@"Data Source={DATASOURCE};Initial Catalog={INITIALCATALOG};Integrated Security=True";
            }
        }
        private SqlConnection connection = new SqlConnection(Database.ConnectionString);
        public SqlConnection SqlConnections
        {
            get { return connection; }
        }
    }
}
