using System;
using System.Collections.Generic;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(new Car(true));
            vehicles.Add(new Car(false));
            vehicles.Add(new Car(false));
            vehicles.Add(new Truck(4));
            vehicles.Add(new Truck(6));
            vehicles.Add(new Truck(8));
            vehicles.Add(new Truck(10));
            vehicles.Add(new Tank());
            vehicles.Add(new Tank());
            vehicles.Add(new Car(true));
            vehicles.Add(new Truck(4));
            vehicles.Add(new Car(false));

            Console.WriteLine("Vehicle\t\t\tDistance Traveled\t\tToll $");
            Console.WriteLine("============================================================================");


            foreach (IVehicle vehicle in vehicles)
            {
                Random r = new Random();
                int miles = r.Next(10, 240);

                if (vehicle.type.Contains("Truck"))
                {
                    Console.WriteLine($"{vehicle.type}\t\t\t{miles}\t\t\t${vehicle.CalculateToll(miles).ToString("#.##")}");
                } else if (vehicle.type.Contains("trailer")) 
                {
                    Console.WriteLine($"{vehicle.type}\t\t{miles}\t\t\t${vehicle.CalculateToll(miles).ToString("#.##")}");
                } else if (vehicle.type.Contains("Tank"))
                {
                    Console.WriteLine($"{vehicle.type}\t\t\t\t{miles}\t\t\t${vehicle.CalculateToll(miles)}");
                }
                else
                {
                    Console.WriteLine($"{vehicle.type}\t\t\t\t{miles}\t\t\t${vehicle.CalculateToll(miles).ToString("#.##")}");
                }
            }

            Console.ReadKey();
        }
    }
}
