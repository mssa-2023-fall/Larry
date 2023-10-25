using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
    public class Group_Anagrams
    {

        #region The Actual Method
        public class Solution_GAnagram
        {
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

                for (int i = 0; i < strs.Length; i++)
                {
                    char[] chars = strs[i].ToCharArray();
                    Array.Sort(chars);
                    string sortedStrings = new string(chars);

                    if (!dict.ContainsKey(sortedStrings))
                    {
                        dict.Add(sortedStrings, new List<string> { strs[i] });
                    }
                    else
                    {
                        dict[sortedStrings].Add(strs[i]);
                    }
                }

                return new List<IList<string>>(dict.Values.ToList());
            }
        }

    }
}
#endregion



public static class Group_Anagram
{
    public static void GroupAnagramOutput()
    {
        string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
        for (int i = 0; i < strs.Length; i++)
        {
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            string sortedStrings = new string(chars);

            sortedStrings.ToList();
            //if dict does not contain the key called (sortedStrings) -> dict @ the key [sortedStrings]  = create new value of [List<string>]
            if (!dict.ContainsKey(sortedStrings))
            {
                dict[sortedStrings] = new List<string>();
            }

            dict[sortedStrings].Add(strs[i]);
        }
        Console.Write(dict.Values.ToList<IList<string>>());


    }
}
