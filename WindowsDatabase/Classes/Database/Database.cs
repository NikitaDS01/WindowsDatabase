using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDatabase.Classes.Database
{
    public static class Database
    {
        private const string DATASOURCE = @"DESKTOP-LQ9AC1C";
        private const string INITIALCATALOG = @"College";

        public static string ConnectionString =>
            $@"Data Source={DATASOURCE};Initial Catalog={INITIALCATALOG};Integrated Security=True";

        public static SqlConnection GetConnection() =>
            new SqlConnection(ConnectionString);

        public static bool Open(SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
                return true;
            }
            return false;
        }
        public static bool Close(SqlConnection connection)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                return true;
            }
            return false;
        }
    }
}
