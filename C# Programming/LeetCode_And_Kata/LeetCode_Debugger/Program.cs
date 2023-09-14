using LeetCode_Debugger;
using System;
using System.Collections.Generic;

namespace LeetCode_Debugger
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] someNumbers = {1,2,3,1,2,3,4,5,6,4,5,6};
           int targetNumber = 5;
           var fromTwoSum = new TwoSum();
           Console.WriteLine(fromTwoSum.TwoSumming(someNumbers, targetNumber));
           fromTwoSum.TwoSumming(someNumbers, targetNumber);
           Console.ReadLine();
           


        }
        
    }
}
