using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.Strings
{
    // Implement a method to perform basic string compression using the counts of repeated characters.
    // For example, aabcccccaaa becomes a2b1c5a3. If compressed is bigger than original, your method should return the original string.
    public static class StringCompression
    {
        public static string CompressString(string x)
        {
            if (string.IsNullOrEmpty(x))
            {
                return x;
            }

            char[] letters = x.ToCharArray();
            StringBuilder b = new StringBuilder();
            int i = 0;
            int j = 1;
            while (i < x.Length - 1)
            {
                if (letters[i] == letters[i + 1])
                {
                    i++;
                    j++;
                }
                else
                {
                    b.Append(letters[i]);
                    b.Append(j);
                    i++;
                    j = 1;
                }
            }

            b.Append(letters[i]); // Append the last letters
            b.Append(j);

            string output = b.ToString();
            if (b.Length > x.Length)
            {
                Console.WriteLine("Compressed string is bigger than original, returning original. Original is: " + x + "; Compressed is: " + output);
                return x;
            }
            else
            {
                Console.WriteLine("Compressed string is: " + output);
                return output;
            }
        }
    }
}
