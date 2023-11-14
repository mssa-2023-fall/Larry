using LeetCode_Debugger;
using System;
using System.Collections.Generic;

namespace LeetCode_Debugger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            //Group_Anagrams.GroupAnagramOutputs();
            //Longest_Consecutive_Sequences.Longest_Consecutive_Sequences_Output();
            // RemoveElementz.RemoveElementzOutput2();
            var RemoveDupes = new RemoveDuplicatesFromSortedArrays(); Console.WriteLine(RemoveDupes.RemoveDuplicates(nums));
            Console.ReadLine();

        }

    }

}