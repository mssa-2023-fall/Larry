namespace LeetCode_Debugger
{
    public class Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {

            return true;

        }
    }
    public static class Palindrome_Numberz
    {
        public static void Palindrome_Numberz_Output1()
        {
            int x = 121;
            bool qwe = false;
            string newString = new string(Convert.ToString(x));
            //Console.WriteLine(newString); //returned 121
            for(int i = 0; i < newString.Length;i++)
            {
                if (newString[0] == newString[^1])
                {
                    qwe = true;
                }
            }
            Console.WriteLine(qwe);
            //Wrong Answer 11506 / 11511 testcases passed

        }
        public static void Palindrome_Numberz_Output2()
        {
            int x = 1000021;
            bool q = false;
            string newString = new string(Convert.ToString(x));
            char[] chars = newString.ToCharArray();
            Array.Sort(chars);
            string newStringa = new string(Convert.ToString(x));
            for(int i = 0; i < newStringa.Length;i++)
            {
                if (newStringa[0] == newStringa[^1])
                {
                    q = true;
                }
            }
            Console.WriteLine(q);
          
        }
    }
}