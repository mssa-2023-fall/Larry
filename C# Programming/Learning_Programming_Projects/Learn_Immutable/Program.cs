using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace LearnImmutable
{
    class Program 
    {
        static void Main(string[] args)
        {
            int[] someArray = {1,2,3,4,5,6,6};
            var someThing = new Testing();
            Console.WriteLine(someThing.ContainsDuplicate(someArray));

            
        }
        
    }
    public class Testing
    {
        public bool ContainsDuplicate(int[] nums)
        {
            bool repeatedNums = false;
            for (int i = nums.Length; i <=0; i++)
            {
                foreach(var n in nums)
                {
                    if(n == i)
                    {
                        repeatedNums = true;
                    }
                    else
                    {
                        repeatedNums = false;
                    }
                }
            }
            return repeatedNums;
        }
    }
}