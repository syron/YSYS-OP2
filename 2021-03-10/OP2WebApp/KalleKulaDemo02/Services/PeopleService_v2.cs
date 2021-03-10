using KalleKulaDemo02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace KalleKulaDemo02.Services
{
    public class PeopleService_v2
    {
        public PeopleService_v2()
        {
            
        }

        public IEnumerable<Person> GetAll()
        {
            var ctx = new demoContext();
            return ctx.People.AsEnumerable();
        }

        public IEnumerable<Person> GetByCarPlate(string s)
        {
            var ctx = new demoContext();
            return ctx.People.Where(p => p.Cars.Count > 0 && p.Cars.Any(c => c.Plate.Contains(s)));
        }

        public IEnumerable<Person> GetPeopleByName(string s)
        {
            var ctx = new demoContext();
            return ctx.People.Where(p => p.Name.Contains(s)).AsEnumerable();
            }

        public bool Add(Person person)
        {
            var ctx = new demoContext();
            ctx.People.Add(person);

            ctx.SaveChanges();

            return true;
        }

        //public bool Add(Personv1 person)
        //{
        //     }

    }
}
