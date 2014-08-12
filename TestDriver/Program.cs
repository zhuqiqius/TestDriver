using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDriver.Strings;

namespace TestDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("Has all unique characters for {0}? The answer is: {1}", "mondaym", HasAllUniqueCharacters.HasAllUniqueCharatersWithDS("mondaym")));
            ReverseString.reverse("thisiscorrect");
            Console.WriteLine(String.Format("{0} is permutation of {1}: {2}", "danliu", "uinlda", StringPermutation.IsPermutation("danliu", "uinlda")));
            Console.WriteLine(String.Format("{0} is permutation of {1}: {2}", "danliu", "sophia", StringPermutation.IsPermutation("danliu", "sophia")));
            ReplacWhiteSpaceWith20Percent.ReplaceWhiteSpaceWith20("Mr. John Smith");
            StringCompression.CompressString("aabcccccaaa");
            StringCompression.CompressString("abcdefgg");
        }
    }
}
