using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDatabase.Classes.Database.Table;

namespace WindowsDatabase.Classes.Database
{
    public static class DatabaseTest
    {
        private static User[] _users = new User[]
        {
            new User(1,"Суслов Илья Арсентьевич","pixil59@gmail.com","2L6KZG","Администратор"),
            new User(2,"Денисов Михаил Романович","frusubroppotou656@yandex.ru","YOyhfR","Менеджер"),
            new User(3,"Филимонов Роберт Васильевич","loudittoimmolau1900@gmail.com","LdNyos","Клиент"),
        };
        public static User GetUser(string login, string password)
        {
            foreach (var user in _users)
            {
                if (user.Login == login &&
                    user.Password == password)
                    return user;
            }
            throw new Exception(
                        "Пользователь не найден. Проверьте правильность данных и повторите попытку входа");
        }

        private static Product[] _products = new Product[]
        {
            new Product("А112Т4", "Лакомство", UnitChange.Piece, 123, 30, "Dreames","PetShop","Product cat", 3, 6,
                "Лакомство для кошек Dreamies Подушечки с курицей, 140 г", "А112Т4.png"),
            new Product("G453T5", "Лакомство", UnitChange.Piece, 123, 30, "True Touch","Zoomir","Product animals", 2, 7,
                "Щетка-варежка True Touch для вычесывания шерсти, синий", "G453T5.jpg")
        };
        public static IReadOnlyCollection<Product> GetProducts() =>
            _products;
        public static Product GetProduct(string id)
        {
            foreach (var product in _products)
            {
                if (product.Id == id)
                    return product;
            }
            return null;
        }
    }
    
}
