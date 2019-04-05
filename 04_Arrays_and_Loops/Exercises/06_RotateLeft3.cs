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
         Given an array of ints length 3, return an array with the elements "rotated left" so {1, 2, 3}
         yields {2, 3, 1}.
         RotateLeft3([1, 2, 3]) → [2, 3, 1]
         RotateLeft3([5, 11, 9]) → [11, 9, 5]
         RotateLeft3([7, 0, 0]) → [0, 0, 7]
         */
        public int[] RotateLeft3(int[] nums)
        {

            //    return new int[] {nums[1], nums[2], nums[0]};
            //}
            int temp = 0;
            for (int i = nums.Length - 1; i < nums.Length; i--)
            {

                if (i > 0)
                {
                    temp = nums[i];
                    nums[i] = nums[i - 1];
                }
                else
                {
                    nums[i] = temp;
                }
            }
            return nums;
        }
    }
}
