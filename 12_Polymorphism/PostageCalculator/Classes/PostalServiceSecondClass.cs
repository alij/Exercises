using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class PostalServiceSecondClass : PostalServiceDelivery
    {
        public override double CalculateRate(int distance, double weight)
        {
            double rate = GetRate(weight);

            return distance * rate;
        }

        static double GetRate(double weight)
        {
            if (weight <= 2)
            {
                return .0035;
            }
            else if (weight <= 8)
            {
                return .0040;
            }
            else if (weight <= 15)
            {
                return .0047;
            }
            else if (weight <= 48)
            {
                return .0195;
            }
            else if (weight <= 128)
            {
                return .0450;
            }
            else
            {
                return .05;
            }
        }

        //TODO: ToString Override
        public override string ToString()
        {
            return "Postal Service (2nd Class)\t$";
        }
    }
}
