using ConsoleApp8.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GameTester
{
    [TestClass]
    public class PlayerTester
    {
        [TestMethod]
        public void ThrowSingleTest()
        {
            Player player = new Player("Robert");

            player.ThrowDice();

            Assert.AreEqual(1, player.Dices.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ThrowNotMoreThan3DicesTest()
        {
            Player player = new Player("Robert");

            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();

        }

        [TestMethod]
        public void Throw10DicesTest()
        {
            Player player = new Player("Robert");
            player.MaxAmountOfDices = 10;

            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();

        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ThrowNotMoreThan10DicesTest()
        {
            Player player = new Player("Robert");
            player.MaxAmountOfDices = 10;

            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();
            player.ThrowDice();

        }
    }
}
