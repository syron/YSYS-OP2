using KalleKulaDemo02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleKulaDemo02.Services
{
    public class PeopleService
    {
        public List<Person> People { get; set; }

        public PeopleService()
        {
            People = new List<Person>() {
                new Person(1, "Robert", "Karlstad"),
                new Person(2, "Winston", "Stockholm"),
                new Person(3, "Leonard", "Torsby"), 
                new Person(4, "Jesko", "Sunne"),
                new Person(5, "Paul", "Lund"),
                new Person(6, "Christian", "Malmö")
            };
        }

        public List<Person> GetAll()
        {
            return People;
        }

        public IEnumerable<Person> GetPeopleByName(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return People;

            return People.Where(p => p.Name.Contains(s));
        }

        public void Add(Person person)
        {
            People.Add(person);
        }

        public void AddRange(List<Person> people)
        {
            People.AddRange(people);
        }
    }
}
