using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        public int NumberOfAxles { get; }

        public string type { get; }

        public Truck() { }

        public Truck(int numberOfAxles)
        {
            if (numberOfAxles == 4)
            {
                type = "Truck (4 axels)";
            } else if (numberOfAxles == 6)
            {
                type = "Truck (6 axels)";
            } else
            {
                type = "Truck (8 axels)";
            }
            NumberOfAxles = numberOfAxles;
        }

        public double CalculateToll(int distance)
        {
            if (NumberOfAxles <= 4)
            {
                return distance * 0.040;
            } else if (NumberOfAxles <= 6)
            {
                return distance * 0.045;
            } else
            {
                return distance * 0.048;
            }
            
        }

        
    }
}
