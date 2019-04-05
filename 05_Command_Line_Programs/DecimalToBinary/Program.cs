using System;


namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {

            // prompt the user to input a series of numbers, assign them to a string array
            // create a double array equal to the length of the string array
            Console.WriteLine("Enter a series of decimal integer's separated by a space: ");
            string numbers = Console.ReadLine();
            string[] stringArray = numbers.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double[] numberArray = new double[stringArray.Length];

            // parse the strings to a double and assign them to the double array
            for (int i = 0; i < stringArray.Length; i++)
            {
                numberArray[i] = double.Parse(stringArray[i]);
            }


            int currentNumber = 1; // this will start at the first binary number, 1
            int counter = 0;    // counter for the 2^X for the input
            string answer = "";  // a string for the final result for each input
            int calculator = 0;  // this will calculate when to input a 1 or 0 to the string
        
            // main loop, starts with the first input from the user
            for (int q = 0; q < numberArray.Length; q++)
            {

                // the while loop includes a counter that tracks how many powers deep an
                // input needs.  I.E. 460 will go to 2^8, the counter will be 9.
                while (currentNumber <= numberArray[q])
                {
                    currentNumber *= 2;
                    counter += 1;
                }

                // For loop that counts down from the counter to 0.
                for (int i = counter; i > 0; i--)
                {
                    // If the power of the current counter power level + the calculator int is less
                    // than the current input . . . 
                    if ((Math.Pow(2, counter - 1) + calculator) <= numberArray[q])
                    {
                        // add the value of the Math.Pow to calculator, decrement counter, 
                        // concatenate a 1 to Answer.  
                        calculator += (int)Math.Pow(2, counter - 1);
                        counter -= 1;
                        answer += "1";

                    }
                    // If the Math.Pow + calculator is greater than the current input . . . 
                    else if ((Math.Pow(2, counter - 1) + calculator) > numberArray[q])
                    {
                        // decrement counter and add a 0 to answer
                        counter -= 1;
                        answer += "0";
                    }
                }

                // reset all the variables to their starting point for the next input
                Console.WriteLine(answer);
                currentNumber = 1;
                calculator = 0;
                answer = "";
            }

            Console.ReadKey();
        }
    }
}
