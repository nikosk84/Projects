using System;
using System.Data;
using System.Data.SqlClient;

namespace SimpleSQLConnector
{
    class Program
    {
        static void Main(string[] args)
        {
            //Connect to database
            using (SqlConnection connection = new SqlConnection(GlobalConnection.Connection("SQLConnectorTester")))
            {
                connection.Open();
                Console.WriteLine($"Connection State: {connection.State}");
                Console.WriteLine("Search by last name: ");

                //Add command to retrieve from stored procedure passing in the connection
                using (SqlCommand command = new SqlCommand("dbo.spPerson_GetByLastName", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@LastName", SqlDbType.VarChar).Value = Console.ReadLine();

                    //Read fetched data and display it to the console
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"Record found: {reader.GetString(0)} {reader.GetString(1)}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No records found.");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
