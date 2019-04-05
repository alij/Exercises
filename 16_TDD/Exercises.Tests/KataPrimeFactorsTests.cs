using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    /* OPTIONAL */
    [TestClass]
    public class KataPrimeFactorsTests
    {
        KataPrimeFactors kataPrimeFactors = new KataPrimeFactors();
        List<int> result = new List<int>();

        [TestMethod]
        public void Factorize2()
        {
            int number = 2;
            result.Add(2);
            CollectionAssert.AreEqual(result, kataPrimeFactors.Factorize(number));
        }

        [TestMethod]
        public void Factorize3()
        {
            int number = 3;
            result.Add(3);
            CollectionAssert.AreEqual(result, kataPrimeFactors.Factorize(number));
        }

        [TestMethod]
        public void Factorize4()
        {
            int number = 4;
            result.Add(2);
            result.Add(2);
            CollectionAssert.AreEqual(result, kataPrimeFactors.Factorize(number));
        }

        [TestMethod]
        public void Factorize5()
        {
            int number = 5;
            int number2 = 15;

            result.Add(5);
            List<int> result2 = new List<int>();
            result2.Add(3);
            result2.Add(5);

            CollectionAssert.AreEqual(result, kataPrimeFactors.Factorize(number));
            CollectionAssert.AreEqual(result2, kataPrimeFactors.Factorize(number2));
        }

        [TestMethod]
        public void Factorize6()
        {
            int number = 6;
            result.Add(2);
            result.Add(3);
            CollectionAssert.AreEqual(result, kataPrimeFactors.Factorize(number));
        }

        [TestMethod]
        public void Factorize7()
        {
            int number = 7;
            result.Add(7);
            CollectionAssert.AreEqual(result, kataPrimeFactors.Factorize(number));
        }

        [TestMethod]
        public void Factorize8()
        {
            int number = 8;
            result.Add(2);
            result.Add(2);
            result.Add(2);
            CollectionAssert.AreEqual(result, kataPrimeFactors.Factorize(number));
        }

        [TestMethod]
        public void Factorize9()
        {
            int number = 9;
            result.Add(3);
            result.Add(3);
            CollectionAssert.AreEqual(result, kataPrimeFactors.Factorize(number));
        }

        [TestMethod]
        public void Factorize10Through13()
        {
            int number = 10;
            int number2 = 11;
            int number3 = 12;
            int number4 = 13;

            result.Add(2);
            result.Add(5);

            List<int> result2 = new List<int>();
            result2.Add(11);

            List<int> result3 = new List<int>();
            result3.Add(3);
            result3.Add(2);
            result3.Add(2);

            List<int> result4 = new List<int>();
            result4.Add(13);

            CollectionAssert.AreEqual(result, kataPrimeFactors.Factorize(number));
            CollectionAssert.AreEqual(result2, kataPrimeFactors.Factorize(number2));
            CollectionAssert.AreEqual(result3, kataPrimeFactors.Factorize(number3));
            CollectionAssert.AreEqual(result4, kataPrimeFactors.Factorize(number4));
        }

        [TestMethod]
        public void Factorize14()
        {
            int number = 14;
            result.Add(2);
            result.Add(7);
            CollectionAssert.AreEqual(result, kataPrimeFactors.Factorize(number));
        }
    }
}
