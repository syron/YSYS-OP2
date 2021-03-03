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
    public class PlayersController : ControllerBase
    {
        [HttpGet]
        public List<Player> Get(string country, string name)
        {
            List<Player> players = new List<Player>()
            {
                new Player() { Id = 1, Name =  "Robert", Score = 1, Country = "Germany" },
                new Player() { Id = 2, Name =  "Winston", Score = -1, Country = "Sweden" },
                new Player() { Id = 3, Name =  "Leonard", Score = 100, Country = "USA" }
            };


            if (!string.IsNullOrWhiteSpace(country))
            {
                players = players.Where(p => p.Country == country).ToList();
            }

            if (!string.IsNullOrWhiteSpace(name))
            {
                players = players.Where(p => p.Name.Contains('n')).ToList();
            }

            return players;
        }
    }
}
