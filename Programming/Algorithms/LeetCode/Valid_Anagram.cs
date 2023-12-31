﻿
namespace LeetCode_Debugger
{
    public class AnagramSolution
    {
        public static bool IsAnagram(string s, string t)
        {
            bool theAnswer = false;
            // Console.WriteLine(AnagramSolution.IsAnagram(firstCase, secondCase));
            //both strings to lower, so the search is case-insensitive
            string loweredFirstCase = s.ToLower();
            string loweredSecondCase = t.ToLower();
            //Make sure that there is not spaces in the $loweredFirstCase/SecondCase strings.
            loweredFirstCase.Replace(" ", "");
            loweredSecondCase.Replace(" ", "");
            char[] charArrayOfFirstCase = loweredFirstCase.ToCharArray();
            char[] charArrayOfSecondCase = loweredSecondCase.ToCharArray();
            //Sort the array so that they become twinsies
            Array.Sort(charArrayOfFirstCase);
            Array.Sort(charArrayOfSecondCase);
            if (loweredFirstCase.Length != loweredSecondCase.Length) { theAnswer = false; }
            //check if the parameter strings are the same length, if not the answer is already false
            if (charArrayOfFirstCase.SequenceEqual(charArrayOfSecondCase)) { theAnswer = true; }
            return theAnswer;
        }
    }
}

///Helpful:
///Remove spaces and convert both input strings to lowercase to ensure a case-insensitive comparison.
///Check if the lengths of the two strings are the same. If they have different lengths, they cannot be anagrams.
///Convert both strings to character arrays, sort the arrays, and then compare them. 
///If the sorted character arrays are the same, the original strings are anagrams.

///Given two strings s and t, return true if t is an anagram of s, and false otherwise.
///
///An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase,
///
///typically using all the original letters exactly once.
///
