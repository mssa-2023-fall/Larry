using System;
using System.Collections;
using System.Diagnostics.Tracing;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Grokking_Algorithms
{
    public class Simple_Binary_Search
    {
        internal void Main(string[] args)
        {
            int[] anArray = {1,3,4,6,7,9,10,12,14,19};
            int guess = 4;
            SimplyPut(anArray,guess);
            
        }
        public int SimplyPut(int[] someArray, int someItem)
        {
            int low = 0;
            int high = someArray.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = someArray[mid];

                if (guess == someItem)
                {
                    return mid;
                }
                if (guess > someItem)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return someItem;
        }

    }

}