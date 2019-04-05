using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class KataRomanNumeralsTests
    {
        KataRomanNumerals kataRomanNumerals = new KataRomanNumerals();
        KataRomanNumerals kataRomanNumerals2 = new KataRomanNumerals();
        KataRomanNumerals kataRomanNumerals3 = new KataRomanNumerals();
        KataRomanNumerals kataRomanNumerals4 = new KataRomanNumerals();
        KataRomanNumerals kataRomanNumerals5 = new KataRomanNumerals();

        [TestMethod]
        public void RomanNumeral1()
        {
            int number = 1;
            int number2 = 2;
            int number3 = 3;

            Assert.AreEqual("I", kataRomanNumerals.ConvertToRomanNumerals(number));
            Assert.AreEqual("II", kataRomanNumerals.ConvertToRomanNumerals(number2));
            Assert.AreEqual("III", kataRomanNumerals.ConvertToRomanNumerals(number3));
        }

        [TestMethod]
        public void RomanNumeral5()
        {
            int number = 5;

            Assert.AreEqual("V", kataRomanNumerals.ConvertToRomanNumerals(number));
        }

        [TestMethod]
        public void RomanNumeral10()
        {
            int number = 10;

            Assert.AreEqual("X", kataRomanNumerals.ConvertToRomanNumerals(number));
        }

        [TestMethod]
        public void RomanNumeralBetween5And10()
        {
            int number1 = 6;
            int number2 = 7;
            int number3 = 8;

            Assert.AreEqual("VI", kataRomanNumerals.ConvertToRomanNumerals(number1));
            Assert.AreEqual("VII", kataRomanNumerals.ConvertToRomanNumerals(number2));
            Assert.AreEqual("VIII", kataRomanNumerals.ConvertToRomanNumerals(number3));
        }

        [TestMethod]
        public void RomanNumeral4()
        {
            int number = 4;

            Assert.AreEqual("IV", kataRomanNumerals.ConvertToRomanNumerals(number));
        }

        [TestMethod]
        public void RomanNumeral9()
        {
            int number = 9;

            Assert.AreEqual("IX", kataRomanNumerals.ConvertToRomanNumerals(number));
        }
    }
}
