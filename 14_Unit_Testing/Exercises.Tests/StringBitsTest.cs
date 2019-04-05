using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        StringBits stringBits = new StringBits();

        string string1 = "Hello";
        string expected1 = "Hlo";

        string string2 = "Hi";
        string expected2 = "H";

        string string3 = "Heeololeo";
        string expected3 = "Hello";

        [TestMethod]
        public void GetBitsWorks()
        {
            string result1 = stringBits.GetBits(string1);
            string result2 = stringBits.GetBits(string2);
            string result3 = stringBits.GetBits(string3);

            Assert.AreEqual(expected1, result1, $"Incorrect return.  Should be {expected1}.");
            Assert.AreEqual(expected2, result2, $"Incorrect return.  Should be {expected2}.");
            Assert.AreEqual(expected3, result3, $"Incorrect return.  Should be {expected3}.");


        }
    }
}
