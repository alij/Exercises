using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {

        MaxEnd3 maxEnd3 = new MaxEnd3();
        int[] array1 = { 1, 2, 3 };
        int[] expected1 = { 3, 3, 3 };

        int[] array2 = { 11, 5, 9 };
        int[] expected2 = { 11, 11, 11 };

        int[] array3 = { 2, 11, 3 };
        int[] expected3 = { 3, 3, 3 };

        int[] result1 = new int[3];
        int[] result2 = new int[3];
        int[] result3 = new int[3];

        [TestMethod]
        public void MakeArrayWorks()
        {
            result1 = maxEnd3.MakeArray(array1);
            result2 = maxEnd3.MakeArray(array2);
            result3 = maxEnd3.MakeArray(array3);

            CollectionAssert.AreEqual(expected1, result1, "Incorrect return, the array should be {3, 3, 3}.");
            CollectionAssert.AreEqual(expected2, result2, "Incorrect return, the array should be {11, 11, 11}.");
            CollectionAssert.AreEqual(expected3, result3, "Incorrect return, the array should be {3, 3, 3}.");
        }

        public void MakeArrayCorrectReturn()
        {
            result1 = maxEnd3.MakeArray(array1);

            Assert.IsNotNull(result1, "The function returned a null array.");
            Assert.AreEqual(3, result1.Length, "The return should be an array of size 3.");

        }
    }
}
