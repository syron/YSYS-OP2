using System;
namespace PlayerStore.Models
{
    public class Player
    {
        public Player(int id, string name, int score, string country)
        {
            Id = id;
            Name = name;
            Score = score;
            Country = country;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public string Country { get; set; }
    }
}
