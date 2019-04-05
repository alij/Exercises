using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string, return the count of the number of times that a substring length 2 appears in the string and
         also as the last 2 chars of the string, so "hixxxhi" yields 1 (we won't count the end substring).
         Last2("hixxhi") → 1
         Last2("xaxxaxaxx") → 1
         Last2("axxxaaxx") → 2
         */
        public int Last2(string str)
        {
            string substring = "";
            if (str.Length >= 2)
            {
                substring = str.Substring(str.Length - 2);
            }
            else
            {
                return 0;
            }

            int counter = 0;

            for (int i = str.IndexOf(substring); i != -1; i = str.IndexOf(substring, i))
            {
                if (str.IndexOf(substring, i) != str.Length - 2)
                {
                    counter++;
                }

                i++;
            }

            return counter;
        }
    }
}
