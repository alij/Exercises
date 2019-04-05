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
         Given 2 arrays of ints, a and b, return true if they have the same first element or they have
         the same last element. Both arrays will be length 1 or more.
         CommonEnd([1, 2, 3], [7, 3]) → true
         CommonEnd([1, 2, 3], [7, 3, 2]) → false
         CommonEnd([1, 2, 3], [1, 3]) → true
         */
        public bool CommonEnd(int[] a, int[] b)
        {
            // check to see if one of the arrays is only length 1,
            // if true, check to see if the first indices are equal,
            // return true if they are
            if (a.Length == 1 || b.Length == 1)
            {
                if (a[0] == b[0])
                {
                    return true;
                }
            }
            else  // if neither array is length 1...
            {
                // check to see if a[0] == b[0] and a/b[length-1]
                // are equal, if yes, return true
                if (a[0] == b[0] || a[a.Length-1] == b[b.Length-1])
                {
                    return true;
                }
            }
            return false;
        }

    }
}
