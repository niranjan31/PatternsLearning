using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PatternsLearning.Strategy
{
    [TestClass]
    public class StrategyUnitTest
    {
        [TestMethod]
        public void RedDuckDrawTest()
        {
            Duck duck = new RedDuck();

            var actual = duck.Draw();
            var expected = "drawn red duck";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RedDuckFlyTest()
        {
            Duck duck = new RedDuck();

            var actual = duck.Fly();
            var expected = "flying";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RedDuckQuackTest()
        {
            Duck duck = new RedDuck();

            var actual = duck.Quack();
            var expected = "quack";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WoodenDuckFlyTest()
        {
            Duck duck = new WoodenDuck();

            var actual = duck.Fly();
            var expected = "cannot fly";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WoodenDuckDrawTest()
        {
            Duck duck = new WoodenDuck();

            var actual = duck.Draw();
            var expected = "drawn wooden duck";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WoodenDuckQuackTest()
        {
            Duck duck = new WoodenDuck();

            var actual = duck.Quack();
            var expected = "mute";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void WoodenDuckFlyByRocketTest()
        {
            Duck duck = new WoodenDuck();

            var actual = duck.Fly();
            var expected = "cannot fly";
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);

            duck.SetFlyBehaviour(new RocketFlyBehaviour());
            actual = duck.Fly();
            expected = "rocket powered fly";
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
