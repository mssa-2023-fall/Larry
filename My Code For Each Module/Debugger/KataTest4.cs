using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugger
{
        public class FourthSolution
        {
            public bool ContainsDuplicate(int[] nums)
            {
            bool repeatedNums = false;
            var lengthOfNums = nums.Length;

                for (int i = lengthOfNums; i == 0; i++)
                {
                    if (lengthOfNums == nums[i])
                    {
                        return repeatedNums = true;
                    }

                    i++;
                }
                return repeatedNums;

            }
        }
 
}





/*
 * 
 * 
 * 
 * 
 * Given an integer array nums, 
 * return true if any value appears at least twice in the array, 
 * and return false if every element is distinct.
 * 
 * 
 * 
 * 
 *  
 Example 1:

Input: nums = [1,2,3,1]
Output: true

 
 
 

 //     ORIGINAL 
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        
    }
}
 
 
 
 
 
 
 
 
 */