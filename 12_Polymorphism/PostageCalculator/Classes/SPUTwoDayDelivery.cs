using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPUTwoDayDelivery : SPUDelivery
    {

        public SPUTwoDayDelivery()
        {
            Rate = 0.050;
        }

        public override double CalculateRate(int distance, double weight)
        {
            return base.CalculateRate(distance, weight);
        }

        public override string ToString()
        {
            return "SPU (2-Day Business)\t\t$";
        }
    }
}
