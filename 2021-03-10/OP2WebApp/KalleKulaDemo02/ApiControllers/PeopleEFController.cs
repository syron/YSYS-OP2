using KalleKulaDemo02.Models;
using KalleKulaDemo02.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalleKulaDemo02.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleEFController : ControllerBase
    {
        private PeopleService_v2 _ps { get; set; }

        public PeopleEFController()
        {
            _ps = new PeopleService_v2();
        }

        [HttpGet]
        public IEnumerable<Person> Get(string s, string plateNumber)
        {
            if (!string.IsNullOrWhiteSpace(s))
            {
                return _ps.GetPeopleByName(s);
            }

            if (!string.IsNullOrWhiteSpace(plateNumber))
            {
                return _ps.GetByCarPlate(plateNumber);
            }
            return _ps.GetAll();
        }

        //[HttpPost]
        //public IEnumerable<Personv1> Post([FromBody]Personv1 person)
        //{
        //    _ps.Add(person);

        //    return _ps.GetAll();
        //}
    }
}
