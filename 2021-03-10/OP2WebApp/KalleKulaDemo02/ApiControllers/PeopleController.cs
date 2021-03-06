﻿using KalleKulaDemo02.Models;
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
        public IEnumerable<Personv1> Get(string s)
        {
            if (!string.IsNullOrWhiteSpace(s))
            {
                return _ps.GetPeopleByName(s);
            }
            return _ps.GetAll();
        }

        [HttpPost]
        public IEnumerable<Personv1> Post([FromBody]Personv1 person)
        {
            _ps.Add(person);

            return _ps.GetAll();
        }
    }
}
