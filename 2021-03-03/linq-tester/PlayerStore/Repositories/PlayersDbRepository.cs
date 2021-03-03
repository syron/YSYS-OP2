using System.Text.Json;
using System.Linq;
using System.IO;
using System;
using System.Collections.Generic;
using PlayerStore.Models;

namespace PlayerStore.Repositories
{
    public class DatabaseRepository<T> : IPlayersRepository<T>
    {
        private string _fileName;

        public DatabaseRepository(string fileName)
        {
            _fileName = fileName;
        }

        public List<T> Read()
        {
            var loadedPlayers = JsonSerializer.Deserialize<List<T>>(File.ReadAllText(_fileName));

            return loadedPlayers;
        }

        public void Save(List<T> listOfItems)
        {
            File.WriteAllText(_fileName, JsonSerializer.Serialize(listOfItems));
        }
    }
}
