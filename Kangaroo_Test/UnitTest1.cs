using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kangaroo_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Kangaroo_Yes()
        {
            var expected = "YES";
            var actual = Kangaroo.Solution.Kangaroo(0, 3, 4, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Kangaroo_NO_DistanceNotDivisible()
        {
            var expected = "NO";
            var actual = Kangaroo.Solution.Kangaroo(10, 4, 25, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Kangaroo_NO_SecondOneFaster()
        {
            var expected = "NO";
            var actual = Kangaroo.Solution.Kangaroo(0, 2, 5, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}
