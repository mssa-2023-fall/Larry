using System.Collections.Generic;
using System;

/*
Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

Example 1:

Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]
Example 2:

Input: nums = [1], k = 1
Output: [1]
*/

namespace LeetCode_Debugger
{
    public class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {

            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (int n in nums)
            {
                if (dict.ContainsKey(n))
                {
                    dict[n]++;
                }
                else
                {
                    dict[n] = 1;
                }
            }
            return dict.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
        }

    }

    public static class TopKFrequentElementz
    {
        public static void TopKFrequentOutput()
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int k = 2; //two of the most frequent elements

            var instantiateThis = new TopKFrequentElements();
            Console.WriteLine(instantiateThis.TopKFrequent(nums, k));
        }
    }

}