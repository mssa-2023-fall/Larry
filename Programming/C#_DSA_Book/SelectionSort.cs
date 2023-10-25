using System;
using System.Diagnostics.Contracts;

namespace CSharp_DSA_Book
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            //Takes on parameter(array)
            for (int i = 0; i < array.Length - 1; i++)
            {   //for loop iterates through the elements until one UNSORTED is left. So - 1.

                //the current index 'i'
                //is the smallest 'minValue = i'
                int minIndex = i;
                T minValue = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    //if(value at position [j] is smaller than the current minimum value).
                    //the(value at position [j] is the new minimum value.
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        //if the object infront of i which is j is smaller than the minValue
                        //make j the new minValue;
                        minIndex = j;
                        minValue = array[j];
                    }

                }   
            Swap(array, i, minIndex);
                //swaps the elements at indeces 'i' to minIndex.
            }
        }
        private static void Swap<T>(T[] array, int first, int second)
        {
            //The goal of this method is to swap indices.
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}