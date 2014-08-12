using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.Strings
{
    // Write a method to replace all white spaces with '20%'. You may assume that the string has sufficient space at the end of the string
    // to hold the additional characters, and that you are given the "true"length of the string. (Note: if implementing in Java, please use a character
    // array so that you can perform this operation in place.
    public static class ReplacWhiteSpaceWith20Percent
    {

        public static string ReplaceWhiteSpaceWith20(string p)
        {
            if (string.IsNullOrEmpty(p))
            {
                return p;
            }
            Console.WriteLine("Before: " + p);

            char[] letters = p.ToCharArray();
            StringBuilder builder = new StringBuilder();
            foreach (char c in letters)
            {
                int diff = c - ' ';
                if (diff == 0)
                {
                    builder.Append("20%");
                }
                else
                {
                    builder.Append(c);
                }
            }
            Console.WriteLine("After: " + builder.ToString());
            return builder.ToString();
        }
    }
}
