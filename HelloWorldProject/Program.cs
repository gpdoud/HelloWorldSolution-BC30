using System;

namespace HelloWorldProject {
    /// <summary>
    /// This is the program class
    /// This is another line of the program class
    /// documentation
    /// </summary>
    class Program {
        static void Main(string[] args) {
            // print to console
            Console.WriteLine("Hello World!");
            var name = "Elena";
            Console.WriteLine($"Hello to {name}");

            var sql = "c:\\repos\\my-sql-scrips\\SalesDb-Script.sql";
            var sqlv = @"c:\repos\my-sql-scrips\SalesDb-Script.sql";
        }
    }
}
