using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connectionString = "Database=demo;Server=.\sqlexpress;Integrated Security=SSPS";
            string connectionString = "Database=demo;Server=.;Integrated Security=SSPI";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT P.[id], P.[name], P.[city] FROM [people] P";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"id: {reader.GetInt32(0)}, name: {reader.GetString(1)}, city: {reader.GetString(2)}");
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
