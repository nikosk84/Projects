using System;
using System.Data.SqlClient;

namespace SimpleSQLConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection("SQLConnectorTester")))
            {
                connection.Open();
                Console.WriteLine($"Server Version: {connection.ServerVersion}");
                Console.WriteLine($"State: {connection.State}");
            }
            Console.ReadLine();
        }
    }
}
