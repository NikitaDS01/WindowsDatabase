using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDatabase.Classes.Database.Table;

namespace WindowsDatabase.Classes.Database.Enum
{
    public static class ConvertEnum
    {
        public const string CLIENT = "Клиент";
        public const string MANAGER = "Менеджер";
        public const string ADMIN = "Администратор";

        public const string PIECE = "шт.";
        public const string KILOGRAM = "кг.";

        public static Role FromStringToRole(string value)
        {
            switch (value)
            {
                case (CLIENT): return Role.Client;
                case (MANAGER): return Role.Manager;
                case (ADMIN): return Role.Admin;
                default: return Role.Guest;
            }
        }
        public static string FromRoleToString(Role role)
        {
            switch (role)
            {
                case (Role.Client): return CLIENT;
                case (Role.Manager): return MANAGER;
                case (Role.Admin): return ADMIN;
                default: return "Гость";
            }
        }
        public static UnitChange FromStringToUnitChange(string value)
        {
            switch (value)
            {
                case (PIECE): return UnitChange.Piece;
                case (KILOGRAM): return UnitChange.Kilogram;
                default: return UnitChange.None;
            }
        }
        public static string FromUnitChangeToString(UnitChange role)
        {
            switch (role)
            {
                case (UnitChange.Piece): return PIECE;
                case (UnitChange.Kilogram): return KILOGRAM;
                default: return "None";
            }
        }
    }
}
