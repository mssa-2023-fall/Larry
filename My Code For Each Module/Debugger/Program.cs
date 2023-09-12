using System;
using System.IO;
using System.Numerics;

namespace Debugger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int someNum = 2;
            var outPut = new RemovingElements();
            Console.WriteLine(outPut.RemoveElement(someArray, someNum));
            Console.ReadLine();

        }
    }
    public class RemovingElements
    {
        public int RemoveElement(int[] nums, int val)
        {
            int savedVal = 0;
            int k = 0;
            List<int> someList = new List<int>();
            foreach (var n in nums)
            {
                if (n != val) 
                {
                    someList.Add(n); 
                }
                else if (nums.Contains(savedVal))
                {
                    someList.Remove(savedVal);
                }
                k = n;
            }
            return k;
        }
    }

}
///Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
///The order of the elements may be changed. 
///Then return the number of elements in nums which are not equal to val.
///Consider the number of elements in nums which are not equal to val be k,
///to get accepted, you need to do the following things:
///Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
///The remaining elements of nums are not important as well as the size of nums.
///Return k.