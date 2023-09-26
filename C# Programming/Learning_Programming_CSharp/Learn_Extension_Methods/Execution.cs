using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Learn_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string name = "jannick";
            //The Capitalize method is an Extension that I created.
            string cap = name.Capitalize(); */
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //Just like the Capitalize, the Average method is an extension that I created. 
            //It shows this when I hover over it.
            var average = numbers.Average();

            int[] ints = new[] {1,2,3};
            var averageInts = ints.Average();
        }
    }
}