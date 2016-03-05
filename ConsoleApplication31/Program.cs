using System;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApplication31
{
    class Program
    {
        static void Main()
        {
            using (var connection = new OracleConnection(ConnectionString))
            {
                connection.Open();
            }
            Console.WriteLine("Done.");
            Console.ReadLine();
        }

        private static string ConnectionString => @"Data Source=localhost/pdborcl;User Id=hr;Password=hr;";
    }
}
