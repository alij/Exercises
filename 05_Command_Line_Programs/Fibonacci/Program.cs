using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take an int input from the user
            Console.Write("Enter an integer to calculate the Fibonacci sequence: ");
            int number = int.Parse(Console.ReadLine());


            // Run the FibonacciFinder method to output the sequence
            FibonacciFinder(number);

            Console.ReadKey();
        }

        public static void FibonacciFinder(int input)
        {
            int firstNumber = 0;  // create an int for the first number of the sequence
            int secondNumber = 1;  // create an int for the second number of the sequence

            for (int i = 0; i < input;)  // for loop to output the sequence.  There is no iterator on i because i will be set to the current number in the sequence,
                                        // the loop will continue as long as i is less than the user's input 
            {


                if (firstNumber <= secondNumber)  // check if firstNum is less than secondNum.  If true, output the number, set firstNum to secondNum, and set i to the secondNum
                {
                    Console.Write(firstNumber + ", ");
                    firstNumber += secondNumber;
                    i = secondNumber;
                    
                }
                else  // otherwise, output secondNum, set secondNum to firstNum, and set i to firstNum
                {
                    Console.Write(secondNumber + ", ");
                    secondNumber += firstNumber;
                    i = firstNumber;
                }


            }
        }
    }

    
}
