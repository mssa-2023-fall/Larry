using System.Collections.Generic;
using System.Text;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;

namespace LeetCode_Debugger
{
    public class Medium_Anagrams
    {
        static void Main(string[] args)
        {
            string[] someArray = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> results = GroupAnagrams(someArray);

        }
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> someList = new List<IList<string>>();
           foreach(var str in strs)
           {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                
                
           }
         


            return someList;
        }
    }
}














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