using ConsoleApp8.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GameTester
{
    [TestClass]
    public class GameTester
    {
        [TestMethod]
        public void AddPlayerTest()
        {
            Player player1 = new Player("Robert");
            Player player2 = new Player("Winston");
            Player player3 = new Player("Leonard");

            Game game = new Game();

            game.AddPlayer(player1);
            game.AddPlayer(player2);
            game.AddPlayer(player3);

            Assert.AreEqual(3, game.Players.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddTooManyPlayersTest()
        {
            Player player1 = new Player("Robert");
            Player player2 = new Player("Winston");
            Player player3 = new Player("Leonard");
            Player player4 = new Player("Leonard2");

            Game game = new Game();

            game.AddPlayer(player1);
            game.AddPlayer(player2);
            game.AddPlayer(player3);
            game.AddPlayer(player4);

        }

    }
}
