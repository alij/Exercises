using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    interface IVehicle
    {
        string type { get; }

        double CalculateToll(int distance);
        
    }
}
