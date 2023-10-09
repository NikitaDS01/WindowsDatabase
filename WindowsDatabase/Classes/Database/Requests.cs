using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDatabase.Classes.Database.Enum;
using WindowsDatabase.Classes.Database.Table;

namespace WindowsDatabase.Classes.Database
{
    public static class Requests
    {
        public static User GetUser(string login, string password)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            string sql = "SELECT [Номер],[Роль],[ФИО],[Логин],[Пароль]" +
                    "FROM [Логин].[Пользователи]" +
                    $"WHERE [Логин] = '{login}' " +
                    $"AND [Пароль] = '{password}'";

            var cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            User user;
            if (reader.Read())
            {
                user = new User(
                    reader.GetInt32(0),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(1)
                    );
                Database.Close(connection);
                return user;
            }

            throw new Exception(
                "Пользователь не найден. Проверьте правильность данных и повторите попытку входа"
                );

        }      
        
        public static List<Product> GetProducts(int count = -1, int page = 1)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            string sql = string.Empty;
            if(count == -1)
            {
                sql = "SELECT [Артикуль],[Наименование],[Единица измерения],[Стоимость],[Максимальная скидки],[Производитель],[Поставщик],[Категория]" +
                    ",[Текущая скидка],[Кол-во на складе],[Описание],[Изображение] " +
                    "FROM [Логин].[Товары] " +
                    "Order by [Наименование] ASC";
            }
            else
            {
                sql = "SELECT [Артикуль],[Наименование],[Единица измерения],[Стоимость],[Максимальная скидки],[Производитель],[Поставщик],[Категория]" +
                    ",[Текущая скидка],[Кол-во на складе],[Описание],[Изображение] " +
                    "FROM [Логин].[Товары] " +
                    "Order by [Наименование] ASC " +
                    $"Offset {page*count} Rows " +
                    $"Fetch Next {count} Rows only";
            }

            var cmd = new SqlCommand(sql, connection);
            
            List<Product> products = new List<Product>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string name = reader.GetString(1);
                UnitChange change = ConvertEnum.FromStringToUnitChange(reader.GetString(2));
                float money = Convert.ToSingle(reader[3]);
                int maxDiscont = reader.GetInt32(4);
                string manufacture = reader.GetString(5);
                string supplier = reader.GetString(6);
                string category = reader.GetString(7);
                int currentDiscont = reader.GetInt32(8);
                int countStorage = reader.GetInt32(9);
                string description = reader.GetString(10);
                string pathImage = reader[11] != DBNull.Value ? reader.GetString(11) : null;
                Product product = new Product(id, name, change,
                    money, maxDiscont, manufacture, supplier, category,
                    currentDiscont, countStorage, description, pathImage
                    );
                products.Add(product);
            }
            
            Database.Close(connection);
            return products;
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
    }
}
