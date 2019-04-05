using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class PostalServiceFirstClass : PostalServiceDelivery
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
                return .035;
            }
            else if (weight <= 8)
            {
                return .040;
            }
            else if (weight <= 15)
            {
                return .047;
            }
            else if (weight <= 48)
            {
                return .195;
            }
            else if (weight <= 128)
            {
                return .450;
            }
            else
            {
                return .5;
            }
        }

        //TODO: ToString Override
        public override string ToString()
        {
            return "Postal Service (1st Class)\t$";
        }
    }
}
