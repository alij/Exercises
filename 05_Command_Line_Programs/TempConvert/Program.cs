using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runAgain = true; // create a bool to check if the user would like to run another temperature
            do

            {
                // ask the user if they want to convert F to C or C to F.  
                Console.Write("Enter 0 to convert Farenheit to Celsius or 1 to convert Celsius to Farenheit: ");
                string measurement = Console.ReadLine();
                int typeOfDegree = int.Parse(measurement);

                // ask the user for a temperature to convert.  Parse the string response to an int.
                Console.Write("Enter the temperature you would like to convert: ");
                string tempChoice = Console.ReadLine();
                double temperature = double.Parse(tempChoice);


                if (typeOfDegree == 0)  // if typeOfDegree is 0, run the FarenheitToCelsius method.
                {
                    double result = FarenheitToCelsius(temperature);
                    Console.WriteLine($"Converting {temperature} Farenheit to Celsius: {result}");  // output the result
                }
                else if (typeOfDegree == 1)  // if typeOfDegree is 1, run the CelsiusToFarenheit method.
                {
                    double result = CelsiusToFarenheit(temperature);
                    Console.WriteLine($"Converting {temperature} Celsius to Farenheit: {result}"); // output the result
                }

                Console.Write("Enter y if you want to run the program again: "); // ask the user if he/she wants to run another temperature, set bool to false if not.
                string again = Console.ReadLine();
                if (again != "y")
                {
                    runAgain = false;
                }

            }
            while (runAgain);

        }

        public static double FarenheitToCelsius(double temp)
        {
            return (temp - 32) / 1.8;
        }

        public static double CelsiusToFarenheit(double temp)
        {
            return temp * 1.8 + 32;
        }
    }
}
