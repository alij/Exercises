using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPUFourDayDelivery : SPUDelivery
    {

        public SPUFourDayDelivery()
        {
            Rate = 0.0050;
        }

        public override double CalculateRate(int distance, double weight)
        {
            return base.CalculateRate(distance, weight);
        }

        public override string ToString()
        {
            return "SPU (4-Day Ground)\t\t$";
        }
    }
}
