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
        public static void Main(string[] args)
        {
            AnsiConsole.Write(new Markup("[bold green]Hello[/] [underline blue]World![/]"));
            Console.ReadKey();
        }
    }
}