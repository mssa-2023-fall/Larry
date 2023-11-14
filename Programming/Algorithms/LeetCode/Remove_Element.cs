using System;
using System.Runtime.CompilerServices;

namespace LeetCode_Debugger{
public class RemoveElement
{
    public int RemoveElements(int[] nums, int val)
    {
        return 0;
    }
}
public static class RemoveElementz
{
    public static void RemoveElementzOutput1()
    {
        int[] nums = { 3, 2, 2, 3 };
        int val = 3;
        var temp = new List<int>();
        for(int i = 0; i < nums.Length;i++) //length = 4 
        {
            if (nums[i] != val)
            {
                temp.Add(nums[i]); //adds 2 2 
            }

        }
        foreach(var n in temp)
        {
            Console.WriteLine("temp: {0} ", n);
        }
        nums = temp.ToArray();
    }
    public static void RemoveElementzOutput2()
    {
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;

        var temp = new List<int>();
        for (int i = 0; i < nums.Length; i++) //length = 4 
        {
            if (nums[i] != val)
            {
                temp.Add(nums[i]); //adds 2 2 
            }

        }
        foreach (var n in temp)
        {
            Console.Write("{0} ", n);
        }
        nums = temp.ToArray();

    }

    public static void RemoveElementzOutput3() //   WORKS
    {
        int[] nums = { 0, 1, 2, 2, 3, 0, 4, 2 };
        int val = 2;

        var temp = new List<int>();
        for(int i = 0; i < nums.Length;i++)
        {
            if (nums[i] != val)
            {
                temp.Add(nums[i]);
            }
        }
        for(int i = 0; i < temp.Count; i++)
        {
            nums[i] = temp[i];
        }
        Console.WriteLine(temp.Count());


    }
}
}
/*
 * Input: nums = [3, 2, 2, 3], val = 3
Output: 2, nums = [2, 2, _, _]
*/