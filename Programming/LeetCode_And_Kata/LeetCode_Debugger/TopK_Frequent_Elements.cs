using System.Collections.Generic;
using System;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
/*
public class Solution
{

    static void Main(string[] args)
    {
        int[] nums = { 3, 0, 1, 0 };
        int k = 2;
        int[] nums2 = new int[nums.Length];
        


        //var kFrequent = new Solution();
        //kFrequent.TopKFrequent(nums, k);
        Array.Sort(nums);
        Array.Reverse(nums);
        
        foreach(var n in nums)
        {
            Console.WriteLine(n);

        }

    }

   /* public int[] TopKFrequent(int[] nums, int k)
    {


        int[] results = new int[nums.Length];
        Array.Sort(results);
        for (int i = 0; i < nums.Length; i++)
        {
        Console.WriteLine(results[i]);
            
            
        }
        return new int[results.Length];
    }
}    */



/* Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

 

Example 1:

Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]
Example 2:

Input: nums = [1], k = 1
Output: [1]
 */

//Basically, if k = 3, give me the top 3 items that are most frequent.






/*One way of solving. I only get 7 of 21 testcases.

    public static int[] TopKFrequent(int[] nums, int k)
    {


        int[] results = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; j < nums.Length; i++)
            {
                if (i == j)
                {
                    HashSet<int> ints = new HashSet<int>();
                    ints.Add(i);
                    results = ints.ToArray();
                    i++;

                }
                break;
            }
        }
        return results;
    }
}*/
