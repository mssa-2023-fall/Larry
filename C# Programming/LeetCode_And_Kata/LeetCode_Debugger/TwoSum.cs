using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Xml.XPath;

namespace LeetCode_Debugger
{
    public class TwoSum 
    {
        public int[] TwoSumming(int[] nums, int target) 
        {
            int[] emptyArray = new int[2];
           for(int i = 0; i >= nums.Length;i++)
           {
            foreach(var n in nums)
            {
                if (nums[i] + nums[i] == target)
                {
                    int[] tempArray = new int [2];
                    
                    emptyArray = tempArray;
                }
                else{i++;}
            }
           }
         return emptyArray;  
        }
    }
}


///two different [n] in nums
///need to equal target
///
///Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
///ou may assume that each input would have exactly one solution, and you may not use the same element twice.
///You can return the answer in any order.

///Example 1:

///Input: nums = [2,7,11,15], target = 9
///Output: [0,1]
///Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
