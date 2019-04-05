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
         Given an array of ints, return true if 6 appears as either the first or last element in the array.
         The array will be length 1 or more.
         FirstLast6([1, 2, 6]) → true
         FirstLast6([6, 1, 2, 3]) → true
         FirstLast6([13, 6, 1, 2, 3]) → false
         */
        public bool FirstLast6(int[] nums)
        {
            // determine if the length of the array is only 1
            // if yes, check if it equals to 6 and return true if yes
            if (nums.Length == 1)
            {
                if (nums[0] == 6)
                {
                    return true;
                }
            }
            else
            {
                // if the array.Length is greater than 1, check
                // both the 0 and length-1 array for a 6
                if (nums[0] == 6 || nums[nums.Length-1] == 6)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
