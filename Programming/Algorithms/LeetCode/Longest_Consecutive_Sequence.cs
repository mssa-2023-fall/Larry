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
            // int[] nums = { 100, 4, 200, 1, 3, 2 }; //1, 2 ,3 ,4 ,100, 200
            int longest = 0;
            Array.Sort(nums);
            var hash = new HashSet<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + 1 == nums[i + 1])
                {
                    hash.Add(i);
                    longest++;
                }

            }
            if (nums.Length == 0)
            {
                return 0;
            }
            else
            {
                return longest + 1;
            }
        }
    }


    public static class Longest_Consecutive_Sequences
    {

        public static void Longest_Consecutive_Sequences_Output1()
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            // int[] nums = {0,3,7,2,5,8,4,6,0,1}; 
            var sortedSet = new SortedSet<int>();
            Array.Sort(nums); //1,2,3,4,100,200 || //0,0,1,2,3,4,5,6,7,8
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + 1 == nums[i + 1])
                {
                    sortedSet.Add(nums[i]);
                    sortedSet.Add(nums[i + 1]);
                }
                else
                {
                    break;
                }
            }
            int lengthOfConsecutiveNums = sortedSet.Count();
            Console.WriteLine(lengthOfConsecutiveNums);

        }


        public static void Longest_Consecutive_Sequences_Output2()
        {
            // int[] nums = { 100, 4, 200, 1, 3, 2 };
            int[] nums = { 0, 3, 7, 2, 5, 8, 4, 6, 0, 1, 100 };  //0,1,2,3,4,5,6,7,8,100
            int longest = 0;
            Array.Sort(nums);
            var hash = new HashSet<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + 1 == nums[i + 1])
                {
                    hash.Add(i);
                    longest++;
                }
            }
        }


        public static void Longest_Consecutive_Sequences_Output3()
        {
            int[] nums = { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 }; //-1 , -1 , 0 , 1 , 3 ,4 ,5 ,6 ,7 ,8, 9
            var numSet = new HashSet<int>(nums);
            if (nums.Length == 0)
            {
                Console.WriteLine(0);
            }
            Array.Sort(nums);
            int longestStreak = 1;
            int currentStreak = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[i - 1] & nums[i] == nums[i - 1] + 1)
                {
                    currentStreak += 1;
                }
                else
                {
                    longestStreak = Math.Max(longestStreak, currentStreak);
                    currentStreak = 1;
                }
            }
            Console.WriteLine(Math.Max(longestStreak, currentStreak));

        }
        public static void Longest_Consecutive_Sequences_Output_ChatGPT()
        {
            int LongestConsecutive(int[] nums)
            {
                // Check if the array is empty; return 0 immediately if it is.
                if (nums.Length == 0) return 0;

                // Create a HashSet and add all elements of the array to it.
                // This will automatically remove any duplicate values and allow for efficient lookup.
                var numSet = new HashSet<int>(nums);
                int longest = 0; // Variable to keep track of the longest consecutive sequence found.

                // Iterate through each number in the HashSet.
                foreach (int num in numSet)
                {
                    // Check if the current number is the start of a new consecutive sequence.
                    // It is the start of a new sequence if the previous number (num - 1) is not in the HashSet.
                    if (!numSet.Contains(num - 1))
                    {
                        int currentNum = num; // The current number being processed.
                        int currentStreak = 1; // Initialize the current streak length to 1.

                        // Continue checking the HashSet for the next consecutive numbers.
                        // If the next consecutive number (currentNum + 1) is found in the HashSet, increment the streak.
                        while (numSet.Contains(currentNum + 1))
                        {
                            currentNum++; // Move to the next consecutive number.
                            currentStreak++; // Increment the current streak length.
                        }

                        // Update the longest streak if the current streak is longer.
                        longest = Math.Max(longest, currentStreak);
                    }
                }

                // Return the longest consecutive sequence length found.
                return longest;
            }

        }
        public static void Longest_Consecutive_Sequences_Output_Memorization()
        {
            int[] nums = { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 };
            if (nums.Length == 0) { Console.WriteLine("Array is empty: 0"); }
            int longest = 0;
            var hashSet = new HashSet<int>(nums);

            foreach (int hash in hashSet)
            {
                int numSet = hash;
                if (!hashSet.Contains(hash - 1))
                {
                    while (hashSet.Contains(hash + 1))
                    {
                        longest++;
                        numSet++;
                    }
                    Math.Max(longest, numSet);
                }
            }



        }

    }

}


// Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.

// You must write an algorithm that runs in O(n) time.



// Example 1:

// Input: nums = [100,4,200,1,3,2]
// Output: 4
// Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.