using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        WordCount wordCount = new WordCount();

        string[] array1 = { "ba", "ba", "black", "sheep" };
        Dictionary<string, int> expected1 = new Dictionary<string, int>{{ "ba", 2 }, {"black", 1}, {"sheep", 1 }};

        string[] array2 = { "a", "b", "a", "c", "b" };
        Dictionary<string, int> expected2 = new Dictionary<string, int> { { "a", 2 }, { "b", 2 }, { "c", 1 } };

        string[] array3 = { "c", "b", "a" };
        Dictionary<string, int> expected3 = new Dictionary<string, int> { { "c", 1 }, { "b", 1 }, { "a", 1 } };

        [TestMethod] 
        public void GetCount()
        {
            Dictionary<string, int> result1 = wordCount.GetCount(array1);
            Dictionary<string, int> result2 = wordCount.GetCount(array2);
            Dictionary<string, int> result3 = wordCount.GetCount(array3);

            CollectionAssert.AreEqual(expected1, result1, "The returned dictionary does not match the expected result.");
            CollectionAssert.AreEqual(expected2, result2, "The returned dictionary does not match the expected result.");
            CollectionAssert.AreEqual(expected3, result3, "The returned dictionary does not match the expected result.");
        }
    }
}
