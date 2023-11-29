using LeetCode_Debugger;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace LeetCode_Debugger
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] nums = { 100, 4, 200, 1, 3, 2 };
            // int[] nums = {};
            int[] nums = { 9, 1, 4, 7, 3, -1, 0, 5, 8, -1, 6 }; //-1 , -1 , 0 , 1 , 3 ,4 ,5 ,6 ,7 ,8, 9
            var leet = new Longest_Consecutive_Sequence();
            // Console.WriteLine(leet.LongestConsecutive(nums));
            // Longest_Consecutive_Sequences.Longest_Consecutive_Sequences_Output2();
            Longest_Consecutive_Sequences.Longest_Consecutive_Sequences_Output_Memorization();

            // Console.WriteLine("Test");
            // Console.ReadLine();
        }

    }

}