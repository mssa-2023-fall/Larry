using System;
namespace LeetCode_Debugger
{
    //int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
    public class RemoveDuplicatesFromSortedArrays
    {
        public int RemoveDuplicates(int[] nums)
        {

            int uniquePos = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if(i+1 == nums.Length || nums[i] != nums[i+1])
                {
                    nums[uniquePos] = nums[i];
                    uniquePos += 1;
                }
            }
            return uniquePos;
        }
    }
}