using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Debugger
{
    public class Longest_Consecutive_Sequence
    {
        public int LongestConsecutive(int[] nums)
        {
            return 0;
        }
    }
    public static class Longest_Consecutive_Sequences
    {
        public static void Longest_Consecutive_Sequences_Output()
        {
            //int[] nums = { 100, 4, 200, 1, 3, 2 }; ///////////  1 2 3 4 100 200 
            int[] nums = { 20, 120, 20, 23, 24, 1 }; ///////////  1 20 23 24 120
            ////////////////////////////////////////////////////////////////////////
            int howManyTimeDoesItRepeat = 0;

            var sortedUniqueNumbers = new SortedSet<int>(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                sortedUniqueNumbers.Add(nums[i]);
            }
            int previous = sortedUniqueNumbers.ElementAt(0);
            int current = sortedUniqueNumbers.ElementAt(1);

            for (int i = 2; i < sortedUniqueNumbers.Count; i++)
            { 
                int nextNumber = sortedUniqueNumbers.ElementAt(i);
                if (nextNumber == previous + current)
                {
                    howManyTimeDoesItRepeat += i;
                }
                previous++;
                current++;

            }
            Console.WriteLine(howManyTimeDoesItRepeat);


        }
    }
}
