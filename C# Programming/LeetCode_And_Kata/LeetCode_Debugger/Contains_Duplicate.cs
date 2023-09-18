

/*
 * 
 * namespace LeetCode_Debugger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] someArray = { 1, 2, 3, 4 };

            
            Console.WriteLine("---Outputting the whole array in a forloop outputs only the value type---");
            Console.WriteLine("\t"+someArray);
            Console.WriteLine("--Outputting the $i as its own variable, outputs an index");
            Console.WriteLine("\t1,2,3,4,5");
            Console.WriteLine("--Outputting the $someArray with a corresponding index of [i], (someArray[i]), outputs the actual value of each integer in array");
            Console.WriteLine("\t10, 20, 30, 40, 50");
            

          //  Console.WriteLine(Solution2.ContainsDuplicate(someArray));
        }
    }

    public class ContainsDuplicateSolution1
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            bool isAnswer = false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        isAnswer = true;
                    }
                    
                    i++;
                }
                return isAnswer;
            }
            return isAnswer;
        }
    }
    public class ContainsDuplicateSolution2
    {
        public static bool ContainsDuplicate2(int[] nums)
        {
            HashSet<int> results = new HashSet<int>(nums);
            return nums.Length != results.Count;
        }
    }
}



Given an integer array nums, return true if any value appears at least twice in the array, 
and return false if every element is distinct.



*/