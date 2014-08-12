using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.Strings
{
    // Given two strings, write a method to decide if one is a permutation of the othe
    public static class StringPermutation
    {
        public static bool IsPermutation(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                return false;
            }

            int[] ax = GetIntArrayForString(a);
            int[] bx = GetIntArrayForString(b);
            for (int i = 0; i < 26; i++)
            {
                if (ax[i] != bx[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static int[] GetIntArrayForString(string x)
        {
            int[] letters = new int[26];
            foreach (char c in x.ToCharArray())
            {
                int diff = c - 'a';
                letters[diff] = letters[diff] + 1;
            }
            return letters;
        }
    }
}
