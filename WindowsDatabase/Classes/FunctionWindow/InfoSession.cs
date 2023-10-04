using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsDatabase.Classes.Database.Table;

public static class InfoSession
{
    private static User _user;

    public static bool IsUserEmpty =>
        _user == null;

    public static User GetUser() =>
        _user;

    public static void SetUser(User user) =>
        _user = user;
}
