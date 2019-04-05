using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPUNextDayDelivery : SPUDelivery
    {

        public SPUNextDayDelivery()
        {
            Rate = 0.075;
        }

        public override double CalculateRate(int distance, double weight)
        {
            return base.CalculateRate(distance, weight);
        }

        //TODO: Override ToString
        public override string ToString()
        {
            return "SPU (Next Day)\t\t\t$";
        }
    }
}
