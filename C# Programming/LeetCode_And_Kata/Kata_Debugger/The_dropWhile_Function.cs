using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



///FAILED 8/11 tests
namespace Kata_Debugger
{
    internal class The_dropWhile_Function
    {
        public static void Main()
        {
            int[] numbers = { 10,11,12,13,143,15,16,17,18,19,20 };
            bool IsEven(int x)
            {
                return x % 2 == 0;
            }
            Func<int, bool> isEven = IsEven;
            
            DropWhile(numbers, isEven);
            Console.ReadLine();
        }

        public static int[] DropWhile(int[] arr, Func<int, bool> pred)
        {
            int[] emptyArray = new int[arr.Length];
            var oddNumbers = arr.Where(n => n % 2 != 0);
            // x % 2 == 0;
            while (!oddNumbers.Any()) {
                foreach (var a in arr)
                {
                    Console.WriteLine(a);
                    Array.Fill(arr, a);
                }
            }
            return new int[] { };
        }
    }
}


/*
Yet another staple for the functional programmer. You have a sequence of values and some predicate for those values. 
You want to remove the longest prefix of elements such that the predicate is true for each element. We'll call this the dropWhile function. 
It accepts two arguments. The first is the sequence of values, and the second is the predicate function. The function does not change the value of the original sequence.

Func<int, bool> isEven = (value) => value % 2 == 0;

dropWhile(new int[] { 2, 4, 6, 8, 1, 2, 5, 4, 3, 2 }, isEven) // -> { 1, 2, 5, 4, 3, 2 }

Your task is to implement the dropWhile function. 
If you've got a span function lying around, this is a one-liner! 
Alternatively, if you have a takeWhile function on your hands, then combined with the dropWhile function, you can implement the span function in one line. 
This is the beauty of functional programming: there are a whole host of useful functions, many of which can be implemented in terms of each other.
*/



///WORKS:
/*foreach(var a in arr)
{
    if (pred(a))
    {
        Console.WriteLine(a);
        int[] newArray = new int[] { a };
        emptyArray = newArray;
    }
}
*/