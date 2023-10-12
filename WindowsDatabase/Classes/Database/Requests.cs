using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

            var request = new StringSelectRequests(sql);
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
        public static List<Product> GetProducts(string nameAttribute, bool isAsc, string manufacture, string search = null, int count = -1, int page = 0)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            string sql = "SELECT [Артикул],[Наименование],[Единица измерения],[Стоимость],[Максимальная скидки],[Производитель],[Поставщик],[Категория]" +
                    ",[Текущая скидка],[Кол-во на складе],[Описание],[Изображение] FROM [Логин].[Товары] ";

            StringSelectRequests requestsSearch = StringSelectRequests.
                GetNewSelect("Select [Артикул] from [Логин].[Товары]").
                AddWhereLike("Наименование", $"%{search}%").
                AddWhereLike("Описание", $"%{search}%");


            StringSelectRequests requests = StringSelectRequests.
                GetNewSelect(sql).
                SetOrderBy(nameAttribute, isAsc).
                SetPage(count, page);

            if (manufacture != "Все  производители")
                requests.AddWhereEqually("Производитель", manufacture);

            if (!string.IsNullOrEmpty(search))
            {
                requests.AddWhereIn("Артикул", requestsSearch);
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
                string nameManufacture = reader.GetString(5);
                string supplier = reader.GetString(6);
                string category = reader.GetString(7);
                int currentDiscont = reader.GetInt32(8);
                int countStorage = reader.GetInt32(9);
                string description = reader.GetString(10);
                string pathImage = reader[11] != DBNull.Value ? reader.GetString(11) : null;
                Product product = new Product(id, name, change,
                    money, maxDiscont, nameManufacture, supplier, category,
                    currentDiscont, countStorage, description, pathImage
                    );
                products.Add(product);
            }
            
            Database.Close(connection);
            return products;
        }
        public static List<string> GetManufacturer() =>
            GetListValue("Производитель");
        public static List<string> GetCategory() =>
            GetListValue("Категория");
        public static int GetCountProduct()
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            string sql = "select count(*) from [Логин].[Товары]";
            var cmd = new SqlCommand(sql, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int count = reader.GetInt32(0);
                Database.Close(connection);
                return count;
            }
            throw new Exception(
               "К сожалению база данных не была подключена. Проверьте соединение"
               );
        }
        public static bool IsThereIndex(string index) =>
            IsThereValue("Артикул", index);
        public static bool IsProductOrder(Product product)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            string sql = "select count(*) from [Логин].[СоставЗаказа] " +
                "where [Артикул]=@Art";

            var cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("Art", product.Id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int count = reader.GetInt32(0);
                Database.Close(connection);
                return count != 0;
            }
            throw new Exception(
               "К сожалению база данных не была подключена. Проверьте соединение"
               );
        }
        public static void InsertProduct(Product product)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            string sql = "INSERT INTO [Логин].[Товары]([Артикул],[Наименование],[Единица измерения],[Стоимость],[Максимальная скидки]," +
                "[Производитель],[Поставщик],[Категория],[Текущая скидка],[Кол-во на складе],[Описание],[Изображение]) ";
            sql += "VALUES (@Art,@Name,@Unit,@Price,@MD,@MF,@S,@Categ,@CD,@CS,@Desc,@Img)";

            var cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("Art", product.Id);
            cmd.Parameters.AddWithValue("Name", product.Name);
            cmd.Parameters.AddWithValue("Unit", ConvertEnum.FromUnitChangeToString(product.UnitChange));
            cmd.Parameters.AddWithValue("Price", product.Price);
            cmd.Parameters.AddWithValue("MD", product.MaxDiscount);
            cmd.Parameters.AddWithValue("MF", product.Manufacturer);
            cmd.Parameters.AddWithValue("S", product.Supplier);
            cmd.Parameters.AddWithValue("Categ", product.Category);
            cmd.Parameters.AddWithValue("CD", product.CurrentDiscount);
            cmd.Parameters.AddWithValue("CS", product.CountStorage);
            cmd.Parameters.AddWithValue("Desc", product.Description);
            if (product.Image != null)
            {
                string format = new ImageFormatConverter().ConvertToString(product.Image.RawFormat);
                if (format == "Jpeg") format = "Jpg";
                cmd.Parameters.AddWithValue("Img", $"{product.Id}.{format}");
            }
            else
            {
                cmd.Parameters.AddWithValue("Img", DBNull.Value);
            }
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void UpdateProduct(Product product)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            string sql = "UPDATE [Логин].[Товары] set [Наименование]=@Name,[Единица измерения]=@Unit,[Стоимость]=@Price," +
                "[Максимальная скидки]=@MD,[Производитель]=@MF,[Поставщик]=@S,[Категория]=@Categ,[Текущая скидка]=@CD," +
                "[Кол-во на складе]=@CS,[Описание]=@Desc,[Изображение]=@Img where [Артикул]=@Art";

            
            var cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("Art", product.Id);
            cmd.Parameters.AddWithValue("Name", product.Name);
            cmd.Parameters.AddWithValue("Unit", ConvertEnum.FromUnitChangeToString(product.UnitChange));
            cmd.Parameters.AddWithValue("Price", product.Price);
            cmd.Parameters.AddWithValue("MD", product.MaxDiscount);
            cmd.Parameters.AddWithValue("MF", product.Manufacturer);
            cmd.Parameters.AddWithValue("S", product.Supplier);
            cmd.Parameters.AddWithValue("Categ", product.Category);
            cmd.Parameters.AddWithValue("CD", product.CurrentDiscount);
            cmd.Parameters.AddWithValue("CS", product.CountStorage);
            cmd.Parameters.AddWithValue("Desc", product.Description);
            if (product.Image != null)
            {
                string format = new ImageFormatConverter().ConvertToString(product.Image.RawFormat);
                if (format == "Jpeg") format = "Jpg";
                cmd.Parameters.AddWithValue("Img", $"{product.Id}.{format}");
            }
            else
            {
                cmd.Parameters.AddWithValue("Img", DBNull.Value);
            }
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void DeleteProduct(Product product)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            string sql = "DELETE FROM [Логин].[Товары] " +
                "WHERE [Артикул]=@Art";
            var cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("Art", product.Id);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private static bool IsThereValue(string nameAttribute, string value)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            var sql = StringSelectRequests.
                GetNewSelect("select count(*) from [Логин].[Товары]").
                AddWhereEqually(nameAttribute, value);

            var cmd = new SqlCommand(sql.GetRequest(), connection);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                int count = reader.GetInt32(0);
                Database.Close(connection);
                return count != 0;
            }
            throw new Exception(
               "К сожалению база данных не была подключена. Проверьте соединение"
               );
        }
        private static List<string> GetListValue(string nameAttribute)
        {
            var connection = Database.GetConnection();
            Database.Open(connection);

            string sql = $"select DISTINCT [{nameAttribute}] from [Логин].[Товары]";

            var cmd = new SqlCommand(sql, connection);
            List<string> manufacturers = new List<string>();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string manufacturer = reader.GetString(0);
                manufacturers.Add(manufacturer);
            }
            Database.Close(connection);
            return manufacturers;
        }
    }
}
