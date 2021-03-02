using System.Text.Json;
using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using PlayerStore.Models;

namespace PlayerStore.Repositories
{
    public class UsersRepository
    {
        private string _fileName;

        public UsersRepository(string fileName)
        {
            _fileName = fileName;
        }

        public List<Player> ReadUsers()
        {
            var loadedPlayers = JsonSerializer.Deserialize<List<Player>>(File.ReadAllText(_fileName));

            return loadedPlayers;
        }

        public void SaveUsers(List<Player> players)
        {
            File.WriteAllText(_fileName, JsonSerializer.Serialize(players));
        }
    }
}
