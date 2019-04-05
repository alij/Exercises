using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public abstract class PostalServiceDelivery : IDeliveryDriver
    {
        public abstract double CalculateRate(int distance, double weight);

    }
}
