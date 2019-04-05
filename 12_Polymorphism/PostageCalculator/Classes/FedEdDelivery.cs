using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{


    public class FedEdDelivery : IDeliveryDriver
    {

        public double CalculateRate(int distance, double weight)
        {
            double rate = 20.00;

            if (WeightCharge(weight))
            {
                rate += 3.00;
            }

            if (DistanceCharge(distance))
            {
                rate += 5.00;
            }

            return rate;
        }

        private bool WeightCharge(double weight)
        {
            if (weight > 48)
            {
                return true;
            }

            return false;
        }

        private bool DistanceCharge(int miles)
        {
            if (miles > 500)
            {
                return true;
            }

            return false;
        }


        public override string ToString()
        {
            return $"FedEd\t\t\t\t$";
        }
    }
}
