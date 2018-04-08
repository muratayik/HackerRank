using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _3D_Surface_Area_Test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void _3D_Surface_Area_1_1_Dimension_1_Cube()
        {
            int[][] values = new int[1][];
            values[0] = new int[] { 1 };
            var expected = 6;
            var actual = _3D_Surface_Area.Solution.surfaceArea(values);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _3D_Surface_Area_1_1_Dimension_4_Cube()
        {
            int[][] values = new int[1][];
            values[0] = new int[] { 4 };
            var expected = 18;
            var actual = _3D_Surface_Area.Solution.surfaceArea(values);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _3D_Surface_Area_1_3_Dimension()
        {
            int[][] values = new int[1][];
            values[0] = new int[] { 1, 2, 3 };
            var expected = 24;
            var actual = _3D_Surface_Area.Solution.surfaceArea(values);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _3D_Surface_Area_2_2_Dimension()
        {
            int[][] values = new int[2][];
            values[0] = new int[] { 2, 2 };
            values[1] = new int[] { 1, 2 };
            var expected = 24;
            var actual = _3D_Surface_Area.Solution.surfaceArea(values);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void _3D_Surface_Area_3_3_Dimension()
        {
            int[][] values = new int[3][];
            values[0] = new int[] { 1, 3, 4 };
            values[1] = new int[] { 2, 2, 3 };
            values[2] = new int[] { 1, 2, 4 };
            var expected = 60;
            var actual = _3D_Surface_Area.Solution.surfaceArea(values);
            Assert.AreEqual(expected, actual);
        }
    }
}
