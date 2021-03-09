using KalleKulaDemo02.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KalleKulaDemo02.Services
{
    public class PeopleService
    {
        public List<Person> People { get; set; }

        public PeopleService()
        {
            
        }

        public List<Person> GetAll()
        {
            List<Person> people = new List<Person>();

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
                            var person = new Person(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                            people.Add(person);
                        }
                    }
                }
            }

            return people;
        }

        public IEnumerable<Person> GetPeopleByName(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return People;

            List<Person> people = new List<Person>();

            string connectionString = "Database=demo;Server=.;Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = $"SELECT P.[id], P.[name], P.[city] FROM [people] P WHERE P.[name] LIKE '%{s}%'";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var person = new Person(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                            people.Add(person);
                        }
                    }
                }
            }

            return people;
        }

        public bool Add(Person person)
        {
            string connectionString = "Database=demo;Server=.;Integrated Security=SSPI";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = $"INSERT INTO [people] ([name], [city]) VALUES ('{person.Name}','{person.City}')";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    if (command.ExecuteNonQuery() > 0)
                        return true;

                    return false;
                }
            }
        }

        public void AddRange(List<Person> people)
        {
            People.AddRange(people);
        }
    }
}
