using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver
{
    // Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?
    public static class HasAllUniqueCharacters
    {
        // 1.1 with using additional data structure
        public static bool HasAllUniqueCharatersWithDS(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                return false;
            }

            int[] letters = new int[26];
            foreach (char c in a.ToCharArray())
            {
                int diff = c - 'a';
                letters[diff] = letters[diff] + 1;
                if (letters[diff] > 1)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool HasAllUniqueCharatersWithoutDS(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                return false;
            }

            // 1.1 without using additional data structure
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] == a[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
