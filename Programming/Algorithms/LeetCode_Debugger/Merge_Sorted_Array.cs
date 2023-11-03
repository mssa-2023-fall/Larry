namespace LeetCode_Debugger
{
    public class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
          for(int i = 0; i < m; i++)
            {
                nums1[m + i] = nums2[i];
            }
          Array.Sort(nums1);

        }
    }
    public static class MergeSortedArrays
    {
        public static void MergeSortedArraysOutput() //Output should be |Output: [1,2,2,3,5,6]
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 2, 5, 6 };
            int n = 3;
            int o = m + n;

            var resultOne = new List<int>(m);
            var resultTwo = new List<int>(n);


            for (int i = 0; i < Math.Min(m,n); i++)
            {
                resultOne.Add(nums1[i]);
                resultTwo.Add(nums2[i]);
            }
            foreach (var c in resultOne)
            {
                Console.WriteLine($"resultOne: {c} "); //1 2 3
            }
            foreach (var c in resultTwo)
            {
                Console.WriteLine($"resultTwo: {c} "); //2 5 6
            }

            Console.WriteLine("\nResults:\n"); //output results var
            var result = new List<int>(); //create a List<int> named result
            result.AddRange(resultOne); //adds the resultOne list to result
            result.AddRange(resultTwo); //adds the resultTwo list to result
            var finalResult = result.ToArray(); //turns the results of the two into an array // 1 2 3 2 5 6

            //replace nums1 with result
            Array.Copy(finalResult, nums1, o);
            Array.Sort(nums1);


            foreach (var c in result) { Console.Write("{0} ",c); } //cant return this because its a list
            Console.WriteLine();
            foreach (var c in nums1) { Console.Write("{0} ", c); } //can return, should return
            Console.WriteLine();
            foreach (var c in finalResult) { Console.Write("{0} ", c); } //can return is an array, but is not called nums1






        }
    }
}

/*You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead be stored inside the array nums1. 
To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
*/