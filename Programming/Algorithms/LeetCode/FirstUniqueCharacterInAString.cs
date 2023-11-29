using Xunit.Sdk;
using System;

namespace LeetCode_Debugger
{

    public class FirstUniqChar
    {
        public int FirstUniqueChar(string s)
        {
            var dict = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}





// public static class FirstUniqueChars
// {
//     public static void FirstUniqueCharsOutput()
//     {
//         string s = "loveleetcode";
       
//     }
// }

