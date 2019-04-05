using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 3 int values, a b c, return their sum. However, if one of the values is 13 then it does not
         count towards the sum and values to its immediate right do not count. So for example, if b is 13, then both
         b and c do not count.
         LuckySum(1, 2, 3) → 6
         LuckySum(1, 2, 13) → 3
         LuckySum(1, 13, 3) → 1
         LuckySum(13, 1, 3) → 3
         LuckySum(13, 13, 3) → 0
         */
        public int LuckySum(int a, int b, int c)
        {
            int currentCount = 0;
            bool countFlag = a != 13;  // set flag to true if a is not 13, flag is true when a number should be counted

            if (countFlag)
            {
                currentCount += a;  // flag is true, add a
            }
            else
            {
                countFlag = false;  // flag is false, keep it false for b
            }

            if (!countFlag)  // flag is false, b will not be counted
            {
                if (b != 13)  // b is not 13, turn the flag true for c
                {
                    countFlag = true;
                }
            }
            else if (countFlag && (b != 13))  // if flag is true, confirm b is not 13
            {
                currentCount += b;  // add b since it is not 13
            }
            else if (countFlag && (b == 13))  // flag is true, but b is 13, turn flag to false for c
            {
                countFlag = false;
            }

            if (countFlag && (c != 13))  // if flag is true and c is not 13, add it to the total
            {
                currentCount += c;
            }

            return currentCount;
        }
    }
}
