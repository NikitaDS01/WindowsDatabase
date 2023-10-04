using System;
using System.Collections.Generic;
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
            var connection = Database.GetConnection();
            try
            {
                Database.Open(connection);
                string sql = "SELECT [Номер],[Роль],[ФИО],[Логин],[Пароль]" +
                    "FROM [Логин].[Пользователи]" +
                    $"WHERE [Логин] = '{login}' " +
                    $"AND [Пароль] = '{password}'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader reader = cmd.ExecuteReader();
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
                    "Пользователь не найден. Проверьте правильность данных и повторите попытку входа");
            }
            finally
            {
                Database.Close(connection);
            }
        }
    }
}
