using LeetCode_Debugger;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
/*
namespace LeetCode_Debugger
{
    public class Binary_Search
    {
        public int Search(int[] nums, int target)
        {
            //43 out of 47 testcases passed
            List<int> iNums = new List<int>();
            int searchResult = 0;
            foreach (var n in nums) { if (n != target) { searchResult = -1; } };
            foreach (var n in nums)
            {
                    iNums.Add(n);
                    if (n == target)
                    {
                       searchResult = iNums.IndexOf(n);
                    }
                    
            }
            if(searchResult < 0) { return -1; }
            
        return searchResult;
        }
    }
}
*/
//what if the target is not in the array?
//int[] nums = {1,2,3,4}  & int target = 5
// I used a foreach loop from the beginning for this issue.

/*static void
{
    var checkResults = new BinarySearch();
    int[] nums = { 1, 3, 4, 6, 8, 9, 10, 20, 30, 40, 50 };

    int target = 20;
    Console.WriteLine(checkResults.Search(nums, target));
    Console.ReadLine();
}
*/


/*
Given an array of integers nums and an integer target, 
write a function to search target in nums. 
If target exists, then return its index. 
Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.

*/