using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace linq_tester
{
    public class Person
    {
        public Person(string name, string city, string country)
        {
            Name = name;
            City = city;
            Country = country;
        }

        public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            Person one = new Person("Robert", "Karlstad", "Sweden");
            Person two = new Person("Winston", "Torsby", "Sweden");
            Person three = new Person("Leonard", "Heidelberg", "Germany");

            List<Person> people = new List<Person>()
            {
                one, two, three
            };

            var cities = people.Select(person => person.City);

            Assert.AreEqual(3, cities.Count());

            var countries = people.Select(person => person.Country).Distinct();

            Assert.AreEqual(2, countries.Count());
        }


        [TestMethod]
        public void TestMethod1()
        {
            List<string> names = new List<string>()
            {
                "Robert",
                "Winston",
                "Leonard",
                "Jesko",
                "Paul"
            };

            var firstName = names.First();
            var lastName = names.Last();

            var first3Names = names.Take(3);
            var secondAndFirstName = names.Skip(1).Take(2);

            var orderedListDesc = names.OrderByDescending(name => name);
            var orderedList = names.OrderBy(name => name);

            if (names.Any(n => n.Contains("o")))
            {

            }

        }
    }

}
