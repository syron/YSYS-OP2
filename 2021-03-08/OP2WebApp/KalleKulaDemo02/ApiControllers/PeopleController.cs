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
    public class PeopleController : ControllerBase
    {
        private PeopleService _ps { get; set; }

        public PeopleController()
        {
            _ps = new PeopleService();
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _ps.GetAll();
        }

        [HttpPost]
        public IEnumerable<Person> Post([FromBody]List<Person> people)
        {
            _ps.AddRange(people);

            return _ps.GetAll();
        }
    }
}
