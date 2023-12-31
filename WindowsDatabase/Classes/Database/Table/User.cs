﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDatabase.Classes.Database.Enum;

namespace WindowsDatabase.Classes.Database.Table
{
    public class User
    {
        private int _id;
        private string _fullName;
        private Role _role;
        private string _login;
        private string _password;

        public User(int id, string fullName, string login, string password, Role role = Role.Client)
        {
            _id = id;
            _fullName = fullName;
            _role = role;
            _login = login;
            _password = password;
        }
        public User(int id, string fullName, string login, string password, string nameRole)
        {
            _id = id;
            _fullName = fullName;
            _role = ConvertEnum.FromStringToRole(nameRole);
            _login = login;
            _password = password;
        }

        public string FullName => _fullName;
        public Role Role => _role;
        public string Login => _login;
        public string Password => _password;

        public static User DefaultUser =>
            GetOrderUser("Гость");
        public static User GetOrderUser(string fullName) =>
            new User(-1, fullName, string.Empty, string.Empty, Role.Guest);
    }
}
