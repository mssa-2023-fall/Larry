namespace LeetCode_Debugger { }
/*{
    public class TwoSum
    {
        static void Main(string[] args)
        {
            int[] numsi = { 2, 7, 11, 15 };
            int targeti = 9;
            var solution = new Solution();
            Console.WriteLine(solution.TwoSum(numsi, targeti));
            Console.ReadLine();
        }



        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            return new int[] { i, j };
                        }
                    }
                }return new int[] { };
            }
        }
    }
}*/
///two different [n] in nums
///need to equal target
///
///Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
///ou may assume that each input would have exactly one solution, and you may not use the same element twice.
///You can return the answer in any order.

///Example 1:

///Input: nums = [2,7,11,15], target = 9
///Output: [0,1]
///Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
