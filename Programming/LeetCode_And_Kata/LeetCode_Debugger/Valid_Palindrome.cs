using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and 
removing all non-alphanumeric characters, it reads the same forward and backward. 
Alphanumeric characters include letters and numbers.
Given a string s, return true if it is a palindrome, or false otherwise.

Example 1:
Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
*/
namespace LeetCode_Debugger
{
    public class Valid_Palindrome
    {
        string s = "A man, a plan, a canal: Panama";

        public bool IsPalindrome(string s)
        {
            return true;
        }
    }
    public static class Valid_Palindromez
    {

        public static void Valid_Palindromez_Output()
        {
            //string s = "A man, a plan, a canal: Panama";
            string s = "race a car";
            bool isItTrue = false;
            

            var replaced = Regex.Replace(s.ToLower(), "[^a-zA-Z0-9]", "");
           

            for (int i = 0; i < replaced.Length;i++)
            {
                char[] chars = replaced.ToCharArray();
                Array.Reverse(chars);
                var strings = new string(chars);

                if (replaced[i] != strings[^1])
                {
                    isItTrue = false;
                    
                }
                
                
            }
            isItTrue = true;




            //Console.WriteLine(replaced);
            Console.WriteLine();
            Console.WriteLine(isItTrue);





        }
    }

}

/*
 * 
 * 
 * var chars = s.ToCharArray();
            Array.Sort(chars);
            Array.Reverse(chars);
 * 
 * 
 * 
 * 
 *  for(int i = 0; i < s.Length; i++)
            {

                if(i.GetType() != typeof(string))
                {
                    s.Replace(s[i], ' ');

                }
            }
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */