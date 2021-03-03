using System;
using System.Collections.Generic;
using System.Linq;
using PlayerStore.Models;
using PlayerStore.Repositories;

namespace PlayerStore.Services
{
    public class PlayersService
    {
        private IPlayersRepository _playersRepository = null;

        public PlayersService(IPlayersRepository playersRepository)
        {
            _playersRepository = playersRepository;
        }

        public Player GetById(int id)
        {
            var players = _playersRepository.ReadUsers();
            return players.FirstOrDefault(u => u.Id == id);
        }

        public List<Player> GetByCountry(string country)
        {
            var players = _playersRepository.ReadUsers();
            return players.Where(p => p.Country == country).ToList();
        }

        public List<Player> GetByScore(int score)
        {
            var players = _playersRepository.ReadUsers();
            return players.Where(p => p.Score == score).ToList();
        }

        public void Save(List<Player> players)
        {
            _playersRepository.SaveUsers(players);
        }
    }
}
