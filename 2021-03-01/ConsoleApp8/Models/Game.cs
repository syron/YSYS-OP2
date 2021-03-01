using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp8.Models
{
    class Game
    {
        int _maxPlayers;
        int _maxDiceThrowsPerPlayer;
        
        public List<Player> Players;

        public Game()
        {
            _maxPlayers = 3;
            _maxDiceThrowsPerPlayer = 3;
            Players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (Players.Count == _maxPlayers)
                throw new Exception($"Max amount of players is {_maxPlayers}");

            player.MaxAmountOfDices = _maxDiceThrowsPerPlayer;

            Players.Add(player);
        }

        public void Run()
        {
            foreach (var player in Players)
            {
                for (var i = 0; i < _maxDiceThrowsPerPlayer; i++)
                {
                    player.ThrowDice();
                }
            }
        }

        public Player GetWinner()
        {
            Player playerWithHighestAmount = null;

            playerWithHighestAmount = Players.OrderByDescending(
                p => p.Dices.Sum(
                    dice => dice.Result)).First();


            return playerWithHighestAmount;
        }
    }
}
