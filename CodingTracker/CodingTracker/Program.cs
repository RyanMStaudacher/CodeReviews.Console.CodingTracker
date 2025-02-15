using System.Globalization;
using Microsoft.Data.Sqlite;
using Spectre.Console;
using Spectre.Console.Cli;
using Dapper;
using System.Configuration;
using System.Collections.Specialized;

namespace CodingTracker
{
    public class MainClass
    {
        public static string connectionString = ConfigurationManager.AppSettings.Get("ConnectionString");

        public static void Main(string[] args)
        {
            AnsiConsole.Write(new Markup("[bold green]Hello[/] [underline blue]World![/]"));
            //string sAttr = ConfigurationManager.AppSettings.Get("Key0");
            //Console.WriteLine("The value of Key0 is " + sAttr);
            //NameValueCollection sAll = ConfigurationManager.AppSettings;
            //foreach(string s in sAll)
            //{
                //Console.WriteLine("Key: " + s + " Value: " + sAll.Get(s));
            //}
            using(SqliteConnection connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                SqliteCommand tableCmd = connection.CreateCommand();
                tableCmd.CommandText = @"CREATE TABLE IF NOT EXISTS coding_tracker_table (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Date TEXT, Quantity INTEGER)";
                tableCmd.ExecuteNonQuery();

                connection.Close();
            }

            Console.ReadLine();
        }
    }
}