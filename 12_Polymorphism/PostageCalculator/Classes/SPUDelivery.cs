using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPUDelivery : IDeliveryDriver
    {
        public double Rate { get; protected set; }

        public virtual double CalculateRate(int distance, double weight)
        {
            weight = Extensions.OuncesToPounds(weight);
            return (((weight * Rate) * distance));
        }
    }
}
