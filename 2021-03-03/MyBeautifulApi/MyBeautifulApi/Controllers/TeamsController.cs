using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBeautifulApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBeautifulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        [HttpGet]
        public List<Team> Get()
        {
            List<Player> players = new List<Player>()
            {
                new Player() { Id = 1, Name =  "Robert", Score = 1, Country = "Germany" },
                new Player() { Id = 2, Name =  "Winston", Score = -1, Country = "Sweden" },
                new Player() { Id = 3, Name =  "Leonard", Score = 100, Country = "USA" }
            };

            Team team = new Team() { Id = 1, Name = "Awesome", Players = players };

            List<Team> teams = new List<Team>() { team };

            return teams;
        }
    }
}
