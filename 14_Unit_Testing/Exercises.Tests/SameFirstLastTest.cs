using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        SameFirstLast sameFirstLast = new SameFirstLast();

        int[] array1 = { 1, 2, 3 };  // returns false
        int[] array2 = { 1, 2, 3, 1 };  // returns true
        int[] array3 = { 1, 2, 1 };  // returns true

        [TestMethod]
        public void IsItTheSame()
        {
            bool array1Length = (array1.Length >= 1);
            bool array2Length = (array2.Length >= 1);
            bool array3Length = (array3.Length >= 1);

            bool result1 = sameFirstLast.IsItTheSame(array1);
            bool result2 = sameFirstLast.IsItTheSame(array2);
            bool result3 = sameFirstLast.IsItTheSame(array3);

            Assert.IsTrue(array1Length, "The array is not length 1 or more.");
            Assert.IsTrue(array2Length, "The array is not length 1 or more.");
            Assert.IsTrue(array3Length, "The array is not length 1 or more.");

            Assert.IsFalse(result1, $"Return should be false, {array1[0]} does not equal {array1[array1.Length - 1]}.");
            Assert.IsTrue(result2, $"Return should be true, {array2[0]} equals {array2[array2.Length - 1]}.");
            Assert.IsTrue(result2, $"Return should be true, {array3[0]} equals {array3[array3.Length - 1]}.");
        }

    }
}
