using PostageCalculator.Classes;
using System;
using System.Collections.Generic;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            List<IDeliveryDriver> drivers = new List<IDeliveryDriver>();
            drivers.Add(new FedEdDelivery());
            drivers.Add(new PostalServiceFirstClass());
            drivers.Add(new PostalServiceSecondClass());
            drivers.Add(new PostalServiceThirdClass());
            drivers.Add(new SPUNextDayDelivery());
            drivers.Add(new SPUTwoDayDelivery());
            drivers.Add(new SPUFourDayDelivery());

            while (isRunning)
            {
                Console.Write("Please enter the weight of the package: ");
                double weight = double.Parse(Console.ReadLine());

                Console.Write("(P)ounds or (O)ounces? ");
                string weightType = Console.ReadLine().ToLower();

                if (weightType == "p")
                {
                    weight = Extensions.PoundsToOunces(weight);
                }

                Console.Write("What distance will it be traveling? ");
                int distance = int.Parse(Console.ReadLine());

                Console.WriteLine("Delivery Method\t\t\t$ Cost");
                Console.WriteLine("-------------------------------------------");
                
                foreach (IDeliveryDriver driver in drivers)
                {
                    Console.WriteLine($"{driver.ToString()}{driver.CalculateRate(distance, weight).ToString("#.##")}");
                }

                Console.WriteLine();
                Console.Write("Enter y if you want to check another rate: ");
                string checkAnother = Console.ReadLine().ToLower();

                if (checkAnother != "y")
                {
                    isRunning = false;
                }


            }
        }
    }
}
