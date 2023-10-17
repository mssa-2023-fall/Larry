using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
namespace Debugger
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] charArray = "Hello".ToCharArray();
            var charEnumerable = charArray.Select((c, index) => new { Char = c, Index = index });

            foreach (var item in charEnumerable)
            {
                char currentChar = item.Char;
                int currentIndex = item.Index;

                // Check if there is a next character
                if (currentIndex < charArray.Length - 1)
                {
                    char nextChar = charArray[currentIndex + 1];
                    Console.WriteLine($"Current Char: {currentChar}, Next Char: {nextChar}");
                }
                else
                {
                    Console.WriteLine($"Current Char: {currentChar}, No Next Char");
                }
            }


        }
    }
}