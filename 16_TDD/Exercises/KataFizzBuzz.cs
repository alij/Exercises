using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string FizzBuzz(int number)
        {
            bool isDivisibleBy3 = DivisibleBy3(number);
            bool isDivisibleBy5 = DivisibleBy5(number);
            bool hasA3 = CheckFor3(number);
            bool hasA5 = CheckFor5(number);


            if ((isDivisibleBy3 && isDivisibleBy5) || (hasA3 && hasA5))
            {
                return "FizzBuzz";
            } else if (hasA3 || (isDivisibleBy3 && !isDivisibleBy5))
            {
                return "Fizz";
            } else if (hasA5 || (isDivisibleBy5 && !isDivisibleBy3))
            {
                return "Buzz";
            } else if (number >= 1 && number <= 100)
            {
                return number.ToString();
            } else
            {
                return "";
            }

        }

        public bool DivisibleBy3(int number)
        {
            if (number % 3 == 0 && number > 0 && number <= 100)
            {
                return true;
            }

            return false;
        }

        public bool DivisibleBy5(int number)
        {
            if (number % 5 == 0 && number > 0 && number <= 100)
            {
                return true;
            }

            return false;
        }

        public bool CheckFor3(int number)
        {
            string theNumber = number.ToString();

            if (number > 0 && number <= 100)
            {

                for (int i = 0; i < theNumber.Length; i++)
                {
                    if (theNumber[i] == '3')
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool CheckFor5(int number)
        {
            string theNumber = number.ToString();

            if (number > 0 && number <= 100)
            {
                for (int i = 0; i < theNumber.Length; i++)
                {
                    if (theNumber[i] == '5')
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
