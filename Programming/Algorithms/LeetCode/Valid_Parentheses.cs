using System.Text;

namespace LeetCode_Debugger
{
    public class ValidParentheses
    {
        // public string s = "()";
        public bool IsValid(string s)
        {
            int length;
            do
            {
                length = s.Length;
                s = s.Replace("()", "").Replace("{}", "").Replace("[]", "");
            }
            while (length != s.Length);
            return s.Length == 0;
        }
    }
    public static class ValidParenthesess
    {

        public static void ValidParenthesesOutput()
        {
            string s = "{}}";
            var chars = s.ToCharArray();
            Array.Sort(chars);

            // for (int i = 0; i < s.Length -1 ; i++)
            // {
            // THEY KEY: Console.WriteLine((int)chars[i]);
            // }
            for (int i = 0; i < s.Length - 1; i++)
            {
                if ((int)chars[i] == (int)chars[i + 1])
                {

                }
            }
        }
    }
}