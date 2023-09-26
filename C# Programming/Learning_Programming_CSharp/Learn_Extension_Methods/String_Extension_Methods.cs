using System;
namespace Learn_Extension_Methods
{
    public class Some_Examples
    {

    }

    //Created a class that creates a method for the 'string' class. I called it 'Capitalize'. 
    //It capitalizes.
    public static class StringExtensions
    {
        public static string Capitalize(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            return char.ToUpper(input[0]) + input.Substring(1);
        }

        public static string FinalChar(this string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return input;
            }
            
            return char[^1];
        }
    }
}
