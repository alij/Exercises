using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class PostalServiceThirdClass : PostalServiceDelivery
    {
        double totalRate { get; }

        public override double CalculateRate(int distance, double weight)
        {
            double rate = GetRate(weight);

            return distance * rate;
        }

        static double GetRate(double weight)
        {
            if (weight <= 2)
            {
                return .0020;
            }
            else if (weight <= 8)
            {
                return .0022;
            }
            else if (weight <= 15)
            {
                return .0024;
            }
            else if (weight <= 48)
            {
                return .0150;
            }
            else if (weight <= 128)
            {
                return .0160;
            }
            else
            {
                return .0170;
            }
        }

        public override string ToString()
        {
            return "Postal Service (3rd Class)\t$";
        }
    }
}
