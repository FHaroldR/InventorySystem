using System;
using System.Data.SQLite;

public class Database
{
    private static string connectionString = "Data Source=users.db;Version=3;";

    public static SQLiteConnection GetConnection()
    {
        return new SQLiteConnection(connectionString);
    }
}
