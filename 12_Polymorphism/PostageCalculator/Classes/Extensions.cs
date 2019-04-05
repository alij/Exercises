using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class Extensions
    {
        public static double PoundsToOunces(double pounds)
        {
            return pounds * 16;
        }

        public static double OuncesToPounds(double ounces)
        {
            return ounces / 16;
        }

    }
}
