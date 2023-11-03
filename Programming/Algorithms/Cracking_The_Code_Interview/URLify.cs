using System.Text;
using System;
using System.Collections;
using System.ComponentModel;

///Write a method to replace all spaces in a string with "%20". You may assume that the string has sufficient space at the end to hold the additional characters.
///and that you are given the "true" length of the string.
///EXAMPLE:
///Input:   "Mr John Smith  ", 13
///Output:  "Mr%20John%20Smith"
///
namespace URLify
{
    class LifyURL
    {
        static void Main(string[] args)
        {
            string thisGuy = "Mr John Smith           ";
            StringBuilder thisGuySB = new StringBuilder();
            for(int i = 0; i < thisGuy.Length;i++)
            {
                if(thisGuySB[i] == ' ')
                {
                    thisGuySB.Append("%20");
                }
                else
                {
                    
                }
            }
        }
    }
}