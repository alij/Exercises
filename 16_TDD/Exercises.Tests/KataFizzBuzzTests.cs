using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
        KataFizzBuzz kataFizzBuzz = new KataFizzBuzz();

        [TestMethod]
        public void FizzBuzzDivisibleBy3()
        {
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(3));

        }

        [TestMethod]
        public void FizzBuzzDivisibleBy5()
        {
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(5));
        }

        [TestMethod]
        public void FizzBuzzDivisibleBy3And5()
        {
            Assert.AreEqual("FizzBuzz", kataFizzBuzz.FizzBuzz(15));

        }

        [TestMethod]
        public void FizzBuzz1To100()
        {
            Assert.AreEqual("4", kataFizzBuzz.FizzBuzz(4));
            Assert.AreEqual("89", kataFizzBuzz.FizzBuzz(89));
        }

        [TestMethod]
        public void FizzBuzzOutside1To100()
        {
            Assert.AreEqual("", kataFizzBuzz.FizzBuzz(-1));
            Assert.AreEqual("", kataFizzBuzz.FizzBuzz(120));
        }

        [TestMethod]
        public void FizzBuzzDivisibleByOrIncludes3()
        {
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(3));
            Assert.AreEqual("Fizz", kataFizzBuzz.FizzBuzz(13));

        }

        [TestMethod]
        public void FizzBuzzDivisibleByOrIncludes5()
        {
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(5));
            Assert.AreEqual("Buzz", kataFizzBuzz.FizzBuzz(59));

        }

        [TestMethod]
        public void FizzBuzzDivisibleByOrIncludes3And5()
        {
            Assert.AreEqual("FizzBuzz", kataFizzBuzz.FizzBuzz(35));
            Assert.AreEqual("FizzBuzz", kataFizzBuzz.FizzBuzz(53));
        }
    }
}
