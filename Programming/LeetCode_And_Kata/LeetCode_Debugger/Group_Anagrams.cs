using System.Collections.Generic;
using System.Text;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Reflection.Metadata;
/*
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

/* Given an array of strings strs, group the anagrams together. You can return the answer in any order.

An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Example 2:

Input: strs = [""]
Output: [[""]]
Example 3:

Input: strs = ["a"]
Output: [["a"]]
*/
namespace LeetCode_Debugger
{
    public class Medium_Anagrams
    {
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {

            IList<IList<string>> listOfListsOfStrings = new List<IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                listOfListsOfStrings.Add(new List<string> { strs[i] });
            }
            return new List<IList<string>>(listOfListsOfStrings);



        }
        static void Main(string[] args)
        {
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            IList<IList<string>> listOfListsOfStrings = new List<IList<string>>();
            IList<IList<string[]>> resultOfListsOfStrings = new List<IList<string[]>>();
            listOfListsOfStrings.Add(new List<string>(strs));
            List<char[]> chars = new List<char[]>();

            foreach(var a in strs)
            {
                var strsToCharArray = a.ToCharArray();
                Array.Sort(strsToCharArray);
                chars.Add(strsToCharArray);
            }
            foreach(var c in chars)
            {
                string[] backToString = new string[strs.Length];
                string backToStringArray = new string(c);
                Array.Fill(backToString,backToStringArray);
                foreach(var b in backToString)
                {
                   
                }
                
            }

        }
    }



    public class UnderstandingAListOfLists
    {
        public void UnderstandingLists()
        {
            IList<IList<string>> listOfLists = new List<IList<string>>
            {
                new List<string> {"apple", "banana"},
                new List<string> {"cat", "dog"},
                new List<string> {"elephant", "fox"}
            };
            foreach (IList<string> strings in listOfLists)
            {
                foreach (string item in strings)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
        }

    }
}
//I want to do the work separately.
//Check Length
//Sort and compare
