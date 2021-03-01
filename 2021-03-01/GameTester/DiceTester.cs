using ConsoleApp8.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GameTester
{
    [TestClass]
    public class DiceTester
    {
        [TestMethod]
        public void DiceIsNotZeroTest()
        {
            Dice dice = new Dice();
            dice.Throw();

            Assert.IsTrue(dice.Result > 0);
        }

        [TestMethod]
        public void DiceIsBetween1And6Test()
        {
            Dice dice = new Dice();
            dice.Throw();

            Assert.IsTrue(dice.Result >= 1);
            Assert.IsTrue(dice.Result <= 6);
        }

        [TestMethod]
        public void DiceMustNotBeThrownTwiceTest()
        {
            var tempresult = 0;

            Dice dice = new Dice();
            dice.Throw();

            tempresult = dice.Result;

            dice.Throw();

            Assert.AreEqual(tempresult, dice.Result);
        }
    }
}
