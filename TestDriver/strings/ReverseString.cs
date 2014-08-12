using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver
{
    // Implement a function void reverse(char* str) in C or C++ which reverses a null-terminated string.
    public static class ReverseString
    {
        // implement a function void reverse (char* str) in C or C++ which reverses a null-terminated string.
        public static void reverse(string b)
        {
            Console.WriteLine("Input string is " + b);
            if (string.IsNullOrEmpty(b))
            {
                return;
            }
            char[] chars = b.ToCharArray();
            int n = b.Length;
            StringBuilder builder = new StringBuilder();
            for (int i = n - 1; i >= 0; i--)
            {
                builder.Append(b[i]);
            }
            Console.WriteLine("Output string is " + builder.ToString());
        }
    }
}
