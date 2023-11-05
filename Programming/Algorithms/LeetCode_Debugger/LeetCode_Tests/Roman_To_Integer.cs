using System.Text;

namespace LeetCode_Debugger
{
    public class RomanToInterger
    {
        public int RomanToInt(string s)
        {
            return 1;
        }

    }
    public static class RomanToIntegers
    {
        public static int RomanToIntegersOutput(string s)
        {
            // string s = "III";
  
            int result = 0;
            var dict = new Dictionary<char, int> { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s))
                {
                    return 0;
                }
                else
                {
                    return dict.Values(s
                }
            }
        }
    }
}

// Symbol       Value
// I             1
// V             5
// X             10
// L             50
// C             100
// D             500
// M             1000

// Example 1:

// Input: s = "III"
// Output: 3
// Explanation: III = 3.
// Example 2:

// Input: s = "LVIII"
// Output: 58
// Explanation: L = 50, V= 5, III = 3.