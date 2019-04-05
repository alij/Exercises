using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataPotterTests
    {
        KataPotter kataPotter = new KataPotter();
        decimal SetOf5 { get; } = (8 * 5) * .75M;
        decimal SetOf4 { get; } = (8 * 4) * .80M;
        decimal SetOf3 { get; } = (8 * 3) * .90M;
        decimal SetOf2 { get; } = (8 * 2) * .95M;

        [TestMethod]
        public void GetCost_CheckForSetOf5()
        {
            int[] bookArray = { 1, 1, 1, 1, 1 };
            Assert.AreEqual(SetOf5, kataPotter.GetCost(bookArray));
        }

        [TestMethod]
        public void GetCost_CheckForSetOf4()
        {
            int[] bookArray = { 1, 1, 1, 1, 0 };
            Assert.AreEqual(SetOf4, kataPotter.GetCost(bookArray));
        }

        [TestMethod]
        public void GetCost_CheckForSetOf3()
        {
            int[] bookArray = { 1, 1, 1, 0, 0 };
            Assert.AreEqual(SetOf3, kataPotter.GetCost(bookArray));
        }

        [TestMethod]
        public void GetCost_CheckForSetOf2()
        {
            int[] bookArray = { 1, 1, 0, 0, 0 };
            Assert.AreEqual(SetOf2, kataPotter.GetCost(bookArray));
        }

        [TestMethod] 
        public void GetCost_MultipleBooks()
        {
            int[] bookArray1 = { 2, 2, 2, 2, 2 };
            int[] bookArray2 = { 2, 2, 2, 2, 1 };
            int[] bookArray3 = { 3, 3, 3, 2, 1 };
            int[] bookArray4 = { 4, 3, 3, 2, 0 };

            decimal result1 = SetOf5 * 2;
            decimal result2 = SetOf5 + SetOf4;
            decimal result3 = SetOf5 + SetOf4 + SetOf3;
            decimal result4 = SetOf4 + SetOf4 + SetOf3 + 8;

            Assert.AreEqual(result1, kataPotter.GetCost(bookArray1));
            Assert.AreEqual(result2, kataPotter.GetCost(bookArray2));
            Assert.AreEqual(result3, kataPotter.GetCost(bookArray3));
            Assert.AreEqual(result4, kataPotter.GetCost(bookArray4));
        }

        [TestMethod]
        public void GetCost_Complex()
        {
            int[] bookArray1 = { 2, 2, 2, 1, 1 };

            decimal result1 = SetOf4 * 2;

            Assert.AreEqual(result1, kataPotter.GetCost(bookArray1));
        }
    }
}
