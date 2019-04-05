using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNamesTest
    {
        [TestMethod]
        public void GetHerdWorks()
        {
            string animal = "lion";
            string animal2 = "giraffe";
            string expected = "Pride";
            string expected2 = "Tower";
            string result;
            string result2;
            AnimalGroupName animalGroupName = new AnimalGroupName();

            result = animalGroupName.GetHerd(animal);
            result2 = animalGroupName.GetHerd(animal2);

            Assert.AreEqual(expected, result, $"The method did not return the correct animal group name." +
                $" {expected} expected, received {result}.");
            Assert.AreEqual(expected2, result2, $"The method did not return the correct animal group name." +
                $" {expected2} expected, received {result2}.");
        }
    }
}
