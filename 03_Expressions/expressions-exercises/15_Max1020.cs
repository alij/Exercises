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
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
        public int Max1020(int a, int b)
        {
            //   bool numbersInRange = (((a >= 10) && (a <= 20)) && ((b >= 10) && (b <= 20)));
            bool aInRange = (a >= 10) && (a <= 20);
            bool bInRange = (b >= 10) && (b <= 20);
            bool numbersInRange = aInRange && bInRange;
            if (numbersInRange)
            {
                if (a > b)
                {
                    return a;
                }
                else
                {
                    return b;
                }
            }
            else
            {
                if (aInRange)
                {
                    return a;
                }
                else if (bInRange)
                {
                    return b;
                }
            }
            return 0;
        }

    }
}
