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
        public static Role FromStringToRole(string value)
        {
            switch (value)
            {
                case ("Client"): return Role.Client;
                case ("Manager"): return Role.Client;
                case ("Admin"): return Role.Client;
                default: return Role.Guest;
            }
        }
        public static string FromRoleToString(Role role) =>
            role.ToString();
    }
}
