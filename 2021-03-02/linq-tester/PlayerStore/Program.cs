using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using PlayerStore.Models;
using PlayerStore.Repositories;
using System.Linq;
using PlayerStore.Services;

namespace PlayerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> Players = new List<Player>()
            {
                new Player(1, "Robert", 100, "Sweden"),
                new Player(2, "Winston", 200, "Germany"),
                new Player(3, "Leonard", 140, "Russia")
            };

            //string fileName = "players.json";
            PlayersDbRepository playersRepository = new PlayersDbRepository("players.json");
            PlayersService playersService = new PlayersService(playersRepository);

            var currentUser = playersService.GetById(2);
            currentUser.Country = "Sweden";

            var swedishPlayers = playersService.GetByCountry("Sweden");
            var playersWithScore150 = playersService.GetByScore(150);
        }
    }
}


