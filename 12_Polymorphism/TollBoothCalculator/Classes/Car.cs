using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Car : IVehicle
    {
        public bool HasTrailer { get; }
        public string type { get; }

        public Car() { }

        public Car(bool hasTrailer)
        {
            if (hasTrailer)
            {
                type = "Car (with trailer)";
            } else
            {
                type = "Car";
            }
            HasTrailer = hasTrailer;
        }

        public double CalculateToll(int distance)
        {
            double toll = distance * 0.020;

            if (HasTrailer)
            {
                return toll + 1;
            } else
            {
                return toll;
            }

        }


    }
}
