using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        NonStart nonStart = new NonStart();

        string part1Of1 = "Hello";
        string part2Of1 = "There";
        string expected1 = "ellohere";

        string part1Of2 = "java";
        string part2Of2 = "code";
        string expected2 = "avaode";

        string part1Of3 = "shotl";
        string part2Of3 = "java";
        string expected3 = "hotlava";

        [TestMethod]
        public void GetPartialStringWorks()
        {
            string result1 = nonStart.GetPartialString(part1Of1, part2Of1);
            string result2 = nonStart.GetPartialString(part1Of2, part2Of2);
            string result3 = nonStart.GetPartialString(part1Of3, part2Of3);

            Assert.AreEqual(expected1, result1, $"Return was {result1}.  Result should be {expected1}");
            Assert.AreEqual(expected2, result2, $"Return was {result2}.  Result should be {expected2}");
            Assert.AreEqual(expected3, result3, $"Return was {result3}.  Result should be {expected3}");
        }

        [TestMethod]
        public void GetPartialString_NoNullString()
        {
            string result1 = nonStart.GetPartialString(part1Of1, part2Of1);
            string result2 = nonStart.GetPartialString(part1Of2, part2Of2);
            string result3 = nonStart.GetPartialString(part1Of3, part2Of3);

            Assert.IsNotNull(result1, "The return is null.");
            Assert.IsNotNull(result2, "The return is null.");
            Assert.IsNotNull(result3, "The return is null.");
        }
    }
}
