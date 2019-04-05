using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void HavePartyWorks()
        {
            CigarParty cigarParty = new CigarParty();
            const int MinimumCigarCount = 40;
            const int MaximumCigarCount = 60;

            int cigars1 = 20;  // should return false
            bool isWeekend1 = false;
            bool result1 = cigarParty.HaveParty(cigars1, isWeekend1);

            int cigars2 = 50;  // should return true
            bool isWeekend2 = false;
            bool result2 = cigarParty.HaveParty(cigars2, isWeekend2);

            int cigars3 = 70;  // should return false
            bool isWeekend3 = false;
            bool result3 = cigarParty.HaveParty(cigars3, isWeekend3);

            int cigars4 = 80;  // should return true
            bool isWeekend4 = true;
            bool result4 = cigarParty.HaveParty(cigars4, isWeekend4);

            int cigars5 = 25;  // should return false
            bool isWeekend5 = true;
            bool result5 = cigarParty.HaveParty(cigars5, isWeekend5);

            Assert.IsFalse(result1, $"Cigars is less than {MinimumCigarCount}, result should be false.");
            Assert.IsTrue(result2, $"Cigars is between {MinimumCigarCount} and {MaximumCigarCount}, result should be true.");
            Assert.IsFalse(result3, $"Cigars is more than {MaximumCigarCount} and it is not a weekend, result should be false.");
            Assert.IsTrue(result4, $"Cigars is over {MaximumCigarCount}, but weekend is true, result should be true.");
            Assert.IsFalse(result5, $"Cigars is less than {MinimumCigarCount}, result should be false.");
            

        }
    }
}
