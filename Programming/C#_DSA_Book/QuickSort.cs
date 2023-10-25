using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__DSA_Book
{
    public static class QuickSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            Sort(array, 0, array.Length - 1);

        }

        private static void Sort<T>(T[] array, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                int pivotIndex = Partition(array, low, high);
                Sort(array, low, pivotIndex - 1); // Before pivotIndex
                Sort(array, pivotIndex + 1, high); //After pivot
            }

        }
        private static int Partition<T>(T[] array, int low, int high) where T : IComparable
        {
            ///The Partition method uses the CompareTo function, 
            ///which is part of the IComparable<T> interface, to compare elements.
            
            T pivot = array[high];  //choosing last element as pivot
            int i = low - 1;        //index of smaller element

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j].CompareTo(pivot) < 0)
                {
                    i++;
                    Swap(array, i, j);
                }

            }
            Swap(array, i + 1, high);
            return i + 1;
        }
        private static void Swap<T>(T[] array, int i, int j)
        {
            T temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}



