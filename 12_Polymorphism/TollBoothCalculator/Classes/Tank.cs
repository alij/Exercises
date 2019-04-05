using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Tank : IVehicle
    {
        public string type { get; }

        public Tank()
        {
            type = "Tank";
        }

        public double CalculateToll(int distance)
        {
            return 0;
        }
    }
}
