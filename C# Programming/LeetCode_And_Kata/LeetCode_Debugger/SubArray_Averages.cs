using System;
using System.Globalization;
/*
namespace LeetCode_Debugger
{
    public class SubArray_Averages
    {
        static void Main(string[] args)
        {
            int[] nums = {2,4,6,8,10,12,14,14,18,20,23,25,27};
            int k = 17;
            int[] avgs = Array.Empty<int>();
            for(int i = nums.Length; i)


//HARD AF












        }
    }
}
*/
















/*
You have an array called nums of integers and an integer k.

You need to compute a new array called avgs, where each element avgs[i] represents the k-radius average for the subarray centered at index i in the nums array.

The k-radius average for a subarray of nums centered at index i with radius k is calculated by finding the average of all elements in nums between the indices i - k and i + k, inclusive.

If there are fewer than k elements before or after the index i in the subarray, then the k-radius average is set to -1 for that index.

The average of x elements is calculated by summing up all those elements and dividing the sum by x. However, note that integer division is used, which means it truncates any fractional part, resulting in an integer value.

For example, if you have four elements: 2, 3, 1, and 5, and you want to find the 2-radius average for each of them:

For the element 2 at index i, the subarray is [2, 3, 1] (because 2 elements before and 2 elements after), and the average is (2 + 3 + 1) / 3 = 6 / 3 = 2.
For the element 3 at index i, the subarray is [2, 3, 1, 5], and the average is (2 + 3 + 1 + 5) / 4 = 11 / 4 = 2.75. However, since it's integer division, it truncates to 2.
Similarly, you compute the k-radius averages for all elements in the nums array following the same logic.
In summary, the problem is asking you to calculate the k-radius average for each element in the nums array, using integer division and handling cases where there are fewer than k elements before or after an index by setting the average to -1. The result should be stored in the avgs array.
*/