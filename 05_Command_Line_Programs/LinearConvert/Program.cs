using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runAgain = true;  // bool to flag whether the user wants to run the program again

            do  // run the program, continue to run if the user opts to run another conversion
            {

                // Prompt the user to ask for a foot or meter input
                Console.Write("Enter 0 to input a measurement in feet, 1 for a measurement in meters: ");
                int unitChoice = int.Parse(Console.ReadLine());



                // Run the appropriate method for foot to meter or meter to foot conversion

                if (unitChoice == 0)  // User chose to enter feet, run FeetToMeters
                {
                    Console.Write("Enter the number of feet: ");
                    double totalFeet = double.Parse(Console.ReadLine());
                    double totalMeters = FeetToMeters(totalFeet);
                    Console.WriteLine($"{totalFeet} converts to {totalMeters} meters.");
                }

                if (unitChoice == 1)  // User chose to enter meters, run MetersToFeet
                {
                    Console.Write("Enter the number of meters: ");
                    double totalMeters = double.Parse(Console.ReadLine());
                    double totalFeet = MetersToFeet(totalMeters);
                    Console.WriteLine($"{totalMeters} converts to {totalFeet} feet.");
                }



                Console.WriteLine("Enter y if you want to run the program again: ");  // prompt the user if he/she wants to run another conversion, anything other than y will terminate
                string again = Console.ReadLine();

                if (again != "y")
                {
                    runAgain = false;
                }
            }
            while (runAgain);

        }

        public static double FeetToMeters(double number)
        {
            return number * 0.3048;
        }

        public static double MetersToFeet(double number)
        {
            return number * 3.2808399;
        }
    }
}
