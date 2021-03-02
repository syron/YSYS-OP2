using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using PlayerStore.Models;
using PlayerStore.Repositories;

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

            string fileName = "players.json";


            UsersRepository usersRepository = new UsersRepository(fileName);
            usersRepository.SaveUsers(Players);

            var users = usersRepository.ReadUsers();
        }
    }
}


