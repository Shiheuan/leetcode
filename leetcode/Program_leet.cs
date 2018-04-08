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

            // test 4
            //String[] strs =
            //{
            //    "asdffffsf",
            //    "asdfaaaes",
            //    "asdfwefsdsdfsdf",
            //    "asdfaaaaes",
            //    "asdfaa",
            //    "asdfe",
            //    "aaasdf"
            //};
            //Console.WriteLine("asd".Contains(""));
            //Console.WriteLine("a".Remove(0, 1));
            //Console.WriteLine(easy.LongestCommonPrefix(strs));

            // test 5
            //String s = "()";
            //Console.WriteLine(easy.IsValid(s));

            // test 6 & 7
            //int[] a = { 1, 2, 2, 2, 3, 5, 8, 10 };
            //int[] c = { 2, 3, 4, 5, 3, 2, 2, 3, 3, 2, 4, 5 };
            //int b = easy.RemoveDuplicates(a);
            //int d = easy.RemoveElement(c, 2);
            //Console.WriteLine($"length: {b}");
            //Console.Write("[ ");
            //for (int i = 0; i < b-1; i++)
            //    Console.Write($" {a[i]},");
            //Console.WriteLine($" {a[b-1]} ]");

            //Console.WriteLine($"length: {d}");
            //Console.Write("[ ");
            //for (int i = 0; i < b - 1; i++)
            //    Console.Write($" {c[i]},");
            //Console.WriteLine($" {c[b - 1]} ]");

            // test 8
            //string str = "mississippi";
            //string nee = "issip";
            //string nee2 = "sippia";
            //Console.WriteLine(easy.StrStr(str, nee));
            //Console.WriteLine(easy.StrStr(str, nee2));

            // test 9
            easy.ListNode n1 = new easy.ListNode(0);
            easy.ListNode n2 = new easy.ListNode(1);
            n2.next = new easy.ListNode(8);
            easy.ListNode a = medium.AddTwoNumbers(n1, n2);
            do
            {
                Console.WriteLine(a.val);
                a = a.next;
            } while (a != null);
            

            // End
            Console.ReadLine();
        }
    }
}
