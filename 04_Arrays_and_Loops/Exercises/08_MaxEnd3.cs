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
         Given an array of ints length 3, figure out which is larger between the first and last elements
         in the array, and set all the other elements to be that value. Return the changed array.
         MaxEnd3([1, 2, 3]) → [3, 3, 3]
         MaxEnd3([11, 5, 9]) → [11, 11, 11]
         MaxEnd3([2, 11, 3]) → [3, 3, 3]
         */
        public int[] MaxEnd3(int[] nums)
        {
            int highNumber = 0; // set an int to hold the high number
            if (nums[0] > nums[2]) 
                // determine the high number of the array, set it to the int
            {
                highNumber = nums[0];
            }
            else
            {
                highNumber = nums[2];
            }

            // iterate through the array assigning highnumber to    
            // all indices
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = highNumber;
            }

            return nums; // return the whole array
            //return new int[] {nums}; ALTERNATIVELY,
            // return new int[] {nums[x], nums[x], nums[x] } where
            // x is the higher of nums[0] or nums[2]
        }

    }
}
