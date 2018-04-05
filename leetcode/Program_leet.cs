using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LEET;

namespace leetcode
{
    class Solution
    {
        static void Main()
        {
            // test 1
            //int a = easy.Reverse2(-1012);
            //Console.WriteLine($"{-10%3}");
            //Console.WriteLine($"{a}");

            // test 2
            //int[] a = { -111, 111, 1232332321 };
            //for (int i = 0; i < a.Length; i ++)
            //{
            //    Console.WriteLine($"{a[i]}");
            //    Console.WriteLine($"{easy.IsPalindrome(a[i])}");
            //}

            // test 3
            //string s = "MCMXCVI";
            //int a = easy.RomanToInt4(s);
            //Console.WriteLine($"{a}");
            String[] strs =
            {
                "asdffffsf",
                "asdfaaaes",
                "asdfwefsdsdfsdf",
                "asdfaaaaes",
                "asdfaa",
                "asdfe",
                "aaasdf"
            };
            Console.WriteLine("asd".Contains(""));
            Console.WriteLine("a".Remove(0, 1));
            Console.WriteLine(easy.LongestCommonPrefix(strs));

            Console.ReadLine();
        }
    }
}
