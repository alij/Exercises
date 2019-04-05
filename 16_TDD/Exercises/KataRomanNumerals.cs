using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataRomanNumerals
    {
        Dictionary<int, string> romanNumerals = new Dictionary<int, string>();

        public string ConvertToRomanNumerals(int number)
        {
            string result = "";


            while (number > 0)
            {
                if (number >= 1000)
                {
                    result += "M";
                    number -= 1000;
                } else if (number >= 500)
                {
                    result += "D";
                    number -= 500;
                } else if (number >= 100)
                {
                    result += "C";
                    number -= 100;
                } else if (number >= 50)
                {
                    result += "L";
                    number -= 50;
                } else if (number >= 10)
                {
                    result += "X";
                    number -= 10;
                }
                else if (number >= 5)
                {
                    result += "V";
                    number -= 5;
                }
                else
                {
                    result += "I";
                    number -= 1;
                    
                }
            }


            if (result.Contains("VIIII"))
            {
                result = result.Remove(result.Length - 5);
                result += "IX";
            }

            if (result.Contains("IIII"))
            {
                result = result.Remove(result.Length - 4);
                result += "IV";
            }

            

            

            return result;


        }
    }
}
