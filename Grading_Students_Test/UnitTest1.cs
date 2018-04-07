using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grading_Students_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void gradingStudents_Pass()
        {
            int[] input = new int[] { 73, 67, 38, 33 };
            int[] expected = new int[] { 75, 67, 40, 33 };
            int[] actual = Grading_Students.Solution.gradingStudents(input);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
