using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDatabase.Classes.Database.Table;

namespace WindowsDatabase.Classes.Database
{
    public static class Requests
    {
        public static User GetUser(string login, string password)
        {
            string sql = "SELECT [Номер],[Роль],[ФИО],[Логин],[Пароль]" +
                    "FROM [Логин].[Пользователи]" +
                    $"WHERE [Логин] = '{login}' " +
                    $"AND [Пароль] = '{password}'";

            SqlDataReader reader = Requests.GetDataReader(sql);
            if (reader.Read())
            {
                return new User(
                    reader.GetInt32(0),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(1)
                    );
            }
            throw new Exception(
                "Пользователь не найден. Проверьте правильность данных и повторите попытку входа"
                );

        }        
        private static SqlDataReader GetDataReader(string sql)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            Database.Close(connection);
            return reader;
        }
        private static DataSet GetDataAdapter(string sql)
        {
            DataSet dataSet = new DataSet();
            var connection = Database.GetConnection();
            Database.Open(connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);

            dataAdapter.Fill(dataSet);
            Database.Close(connection);
            return dataSet;
        }
        private static bool ExecuteNonQuery(string sql)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            SqlCommand cmd = new SqlCommand(sql, connection);

            Database.Close(connection);
            return cmd.ExecuteNonQuery() != 0;
        }
    }
}
