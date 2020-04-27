using System;
using Microsoft.Data.SqlClient;

namespace VDQueryDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString =
            "Server=localhost,1433;Database=QLQuan;User Id=sa;Password=reallyStrongPwd123;";

            // Provide the query string with a parameter placeholder.
            string queryString =
                "SELECT * "
                    + "FROM ThucUong";

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
                {
                    // Create the Command and Parameter objects.
                    SqlCommand command = new SqlCommand(queryString, connection);

                    // Open the connection in a try/catch block.
                    // Create and execute the DataReader, writing the result
                    // set to the console window.
                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            Console.WriteLine("\t{0}\t{1}\t\t{2}\t\t{3}",
                                reader[0], reader[1], reader[2], reader[3]);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    Console.ReadLine();
                }
            }
    }
}
