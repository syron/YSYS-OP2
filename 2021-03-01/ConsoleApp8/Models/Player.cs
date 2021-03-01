using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Models
{
    class Player
    {
        public string Name { get; set; }
        public List<Dice> Dices { get; set; }

        public int MaxAmountOfDices = 3;

        public Player(string name)
        {
            Name = name;
            Dices = new List<Dice>();
        }

        public void ThrowDice()
        {
            if (Dices.Count < MaxAmountOfDices)
            {
                var dice = new Dice();
                dice.Throw();

                Dices.Add(dice);
            } else
            {
                throw new Exception($"Max amount of throws per player is {MaxAmountOfDices}");
            }
        }
    }
}
