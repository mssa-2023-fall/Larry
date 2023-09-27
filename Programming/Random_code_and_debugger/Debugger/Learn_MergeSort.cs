using LeetCode_Debugger;

namespace LeetCode_Debugger
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateSortedNumber(10);

        }
        public static int[] GenerateSortedNumber(int size)
        {
            var array = new int[size];

            for (int i = 0; i < size; i++)
                array[i] = i;

            return array;
        }
        public int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);

                MergeArray(array, left, middle, right);
            }
            return array;
        }
        public void MergeArray(int[] array, int left, int middle, int right)
        {
            //the middle is a balancer, like the switch cup game
            var leftArrayLength = middle - left + 1; //helps me define temporary arrays to hold values // during the sorting process
            var rightArrayLength = right - middle; // helps me define temporary arrays to hold values // during the sorting process
            var leftTempArray = new int[leftArrayLength];
            var rightTempArray = new int[rightArrayLength];
            int i, j;

            for (i = 0; i < leftArrayLength; ++i)//i will stop at the max left length

            { leftTempArray[i] = array[left + i]; }//per the increment of $leftTempArray, continue to add an integer that is the value of the index of $array[$left + i]. Which means it continues to go left.

            for (j = 0; j < rightArrayLength; ++j) //j will stop at the max right length

            { rightTempArray[j] = array[middle + 1 + j]; }// per the increment of $rightTempArray, continues to add an integer to the array that is the value of the index at $array[$middle + 1 + j]. Essentially continuing to go right.

            i = 0;//this is not the $i within the scope of the for loop
            j = 0;//this is not the $j within the scope of the for loop
            int k = left; //k equals the $left parameter

            while (i < leftArrayLength && j < rightArrayLength) //While $i and $j are less than max lengths of respective arrays
            {
                if (leftTempArray[i] <= rightTempArray[j]) //if index [i] on the $leftTempArray is less than index [j] in the $rightTempArray
                {
                    array[k++] = leftTempArray[i++];//the index that is equal to $left in $array will increment in accordance to $leftArrayLength[i++] until $leftArrayLength[i] reaches max length of $leftArrayLength
                }
                else
                {
                    array[k++] = rightTempArray[j++];//add to 
                }
            }
            while (i < leftArrayLength)
            {
                array[k++] = leftTempArray[i++];
            }
            while (j < rightArrayLength)
            {
                array[k++] = rightTempArray[j++];
            }
        
        }
    }
}