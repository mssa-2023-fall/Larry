using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learn_BinarySearch
{
    public class Searching
    {
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Check if the middle element is equal to the target
                if (array[mid] == target)
                    return mid;

                // If the target is greater, ignore the left half
                if (array[mid] < target)
                    left = mid + 1;
                // If the target is smaller, ignore the right half
                else
                    right = mid - 1;
            }

            // If the target is not in the array, return -1
            return -1;
        }

        public static void Main(string[] args)
        {
            int[] sortedArray = new int[1000];
            int target = 50;

            int result = BinarySearch(sortedArray, target);

            if (result != -1)
                Console.WriteLine($"Element {target} found at index {result}");
            else
                Console.WriteLine($"Element {target} not found in the array");
        }
    }
}
