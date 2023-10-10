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
                    "FROM [Логин].[Пользователи] ";

            var request = new StringRequests(sql);
            request.AddWhereEqually("Логин", login).AddWhereEqually("Пароль", password);

            var cmd = new SqlCommand(request.GetRequest(), connection);
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
        
        public static List<Product> GetProducts(string nameAttribute, bool isAsc, string search = null, int count = -1, int page = 0)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            string sql = "SELECT [Артикуль],[Наименование],[Единица измерения],[Стоимость],[Максимальная скидки],[Производитель],[Поставщик],[Категория]" +
                    ",[Текущая скидка],[Кол-во на складе],[Описание],[Изображение] FROM [Логин].[Товары] ";
            
            StringRequests requests = new StringRequests(sql);
            requests.
                SetOrderBy(nameAttribute, isAsc).
                SetPage(count, page);

            if (!string.IsNullOrEmpty(search))
            {
                requests.
                    AddWhereLike("Наименование", $"%{search}%").
                    AddWhereLike("Описание", $"%{search}%");
            }

            var cmd = new SqlCommand(requests.GetRequest(), connection);
            
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
    }
}
