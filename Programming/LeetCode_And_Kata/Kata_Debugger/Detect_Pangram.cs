/*A pangram is a sentence that contains every single letter of the alphabet at least once. 
For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, 
because it uses the letters A-Z at least once (case is irrelevant).

Given a string, detect whether or not it is a pangram. Return True if it is, False if not. Ignore numbers and punctuation.*/

using System;
using System.Linq;
using System.Collections.Generic;


namespace Kata_Debugger
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine(Kata.IsPangram(str));

        }
    }
    public static class Kata
    {

        public static bool IsPangram(string str)
        {
            bool someBool = false;
            char[] chars1 = str.ToCharArray();
            HashSet<char> chars = new HashSet<char>();
            { foreach (var s in str) { chars.Add(s); } }
            foreach (var n in chars1)
            {
                if (chars.Contains(n))
                {
                    someBool = true;
                }
                else
                {
                    someBool = false;
                }
                
            }
            return someBool;
        }
    }
}