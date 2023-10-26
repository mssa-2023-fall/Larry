using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
You must write an algorithm that runs in O(n) time and without using the division operation.

Example 1:
Input: nums = [1,2,3,4]
Output: [24,12,8,6]

Example 2:
Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
*/
namespace LeetCode_Debugger
{
    public class Product_Of_Array_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            return new int[nums.Length];

        }
    }


    public static class Product_Of_Array_Except_Selfz
    {
        public static void ProductExceptSelfOutput()
        {
            int[] nums = { 1, 2, 3, 4 };

            int n = nums.Length;

            int[] left = new int[n];
            int[] right = new int[n];
            int[] result = new int[n];

            left[0] = nums[0];
            for(int i = 1; i < n; i++)
            {
                left[i] = left[i - 1] * nums[i - 1];
            }
            right[n - 1] = 1;
            for(int i = n -2; i >= 0; i--)
            {
                right[i] = right[i + 1] * nums[i + 1];
            }

            




            //end of while


            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Current:\n");
            //foreach (var d in dict.Keys.ToArray()) { Console.Write($"{d} "); }
            Console.WriteLine("---------------------------------------------------");
           // foreach (var d in dict.Values.ToArray()) { Console.Write($"{d} "); }
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("""

       
                Input: nums = [1,2,3,4]
                Output: [24,12,8,6]

                 Given an integer array nums, return an array answer such that answer[i] 
                 is equal to the product of all the elements of nums except nums[i].
                 The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.


                """);


        }
        public static void MultiplyMe(int number)
        {

        }
    }

}