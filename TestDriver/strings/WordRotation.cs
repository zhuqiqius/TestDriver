using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.Strings
{
    // Assume that you have a method isSubstring which checks if one word is a substring of another.
    // Given two strings, s1 and s2, write code to check if s2 is a rotation of s1 using only one call to isSubstring 
    // (e.g., "waterbottle" is a rotation of "erbottlewat")
    public static class WordRotation
    {
        public static bool IsWordRotation(string a, string b)
        {
            int count = a.Length;
            int count1 = b.Length;

            if (count == 0 || count1 == 0 || count != count1)
            {
                return false;
            }
            else
            {
                char[] a1 = a.ToLowerInvariant().ToCharArray();
                char[] b1 = b.ToLowerInvariant().ToCharArray();

                int i = 0;
                int k = 1;

                while (i < count)
                {
                    if (b1[i] != a1[0])
                    {
                        i++;
                    }
                    else if (b1[i + 1] != a1[1])
                    {
                        i++;
                    }
                    else
                    {
                        for (int j = 1; j < count - i; j++)
                        {
                            if (b1[i + j] == a1[j])
                            {
                                k++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    }
                }

                string left = b.ToLowerInvariant().Substring(0, i) + b.ToLowerInvariant().Substring(i + k - 1, count - i - k);
                return isSubString(left, a.ToLowerInvariant());
            }
        }

        private static bool isSubString(string left, string a)
        {
            int startIndex = a.IndexOfAny(left.ToCharArray());
            return (startIndex != -1);
        }
    }
}
