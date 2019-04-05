using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {
        [TestMethod]
        public void GetLuckWorks()
        {
            Lucky13 lucky13 = new Lucky13();

            int[] nums1 = { 0, 2, 4 };  // should return true
            int[] nums2 = { 1, 2, 3 };  // should return false
            int[] nums3 = { 1, 2, 4 };  // should return false

            bool result1 = lucky13.GetLucky(nums1);
            bool result2 = lucky13.GetLucky(nums2);
            bool result3 = lucky13.GetLucky(nums3);

            Assert.IsTrue(result1, "The array had no 1s or 3s, this should be true.");
            Assert.IsFalse(result2, "The array had a 3, this should be false.");
            Assert.IsFalse(result3, "The array has a 1, this should be false.");
        }
    }
}
