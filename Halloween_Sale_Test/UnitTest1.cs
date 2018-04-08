using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Halloween_Sale_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Halloween_Sale_Solution_Buy_Zero()
        {
            var expected = 0;
            var actual = Halloween_Sale.Solution.howManyGames(100, 10, 20, 60);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Halloween_Sale_Solution_Buy_One()
        {
            var expected = 1;
            var actual = Halloween_Sale.Solution.howManyGames(50, 15, 20, 75);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Halloween_Sale_Solution_Buy_6()
        {
            var expected = 6;
            var actual = Halloween_Sale.Solution.howManyGames(20, 3, 6, 80);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Halloween_Sale_Solution_Buy_7()
        {
            var expected = 7;
            var actual = Halloween_Sale.Solution.howManyGames(20, 3, 6, 85);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Halloween_Sale_Solution_Buy_46()
        {
            var expected = 46;
            var actual = Halloween_Sale.Solution.howManyGames(9, 16, 7, 324);
            Assert.AreEqual(expected, actual);
        }
    }
}
