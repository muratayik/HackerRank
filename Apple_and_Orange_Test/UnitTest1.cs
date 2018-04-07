using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Apple_and_Orange_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void countApplesAndOranges_Pass_1()
        {
            var leftSideOfHouse = 7;
            var rightSideOfHouse = 11;
            var larrysPoisition = 5;
            var bobsPosition = 15;
            var apples = new int[] { -2, 2, 1 };
            var oranges = new int[] { 5, -6 };
            var expected = "1 1";
            var actual = Apple_and_Orange.Solution.CountApplesAndOranges(leftSideOfHouse, rightSideOfHouse, larrysPoisition, bobsPosition, apples, oranges);
            Assert.AreEqual(expected, actual);
        }
    }
}
