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
            //easy.ListNode n1 = new easy.ListNode(0);
            //easy.ListNode n2 = new easy.ListNode(1);
            //n2.next = new easy.ListNode(8);
            //easy.ListNode n3 = new easy.ListNode(2);
            //n3.next = new easy.ListNode(4);
            //n3.next.next = new easy.ListNode(3);
            //easy.ListNode n4 = new easy.ListNode(5);
            //n4.next = new easy.ListNode(6);
            //n4.next.next = new easy.ListNode(4);
            //easy.ListNode a = medium.AddTwoNumbers(n3, n4);
            //do
            //{
            //    Console.WriteLine(a.val);
            //    a = a.next;
            //} while (a != null);
            // 不迭代就按这种方式访问啊

            // test 10
            //string s = "aab";
            //string s = "dvdf";
            //string s = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~ abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            //Console.WriteLine(medium.LengthOfLongestSubstring(s));
            //Console.WriteLine(s);
            // test string allocating
            //string c = s;
            //s += "22222";
            //Console.WriteLine("s: " + s);
            //Console.WriteLine("c: " + c);

            // test 11
            //int[] nums = { 1, 3, 4, 5 };
            //Console.WriteLine(easy.SearchInsert(nums, 0));
            // End

            // test List<> and Array.
            //easy[] num = new easy[4];
            //List<easy> num = new List<easy>(4);
            //Console.WriteLine(num.Count); // display: 0.
            //num[3] = new easy(); // List error out range.
            //easy ea = new easy();
            //num[1] = ea;

            //Console.WriteLine(num.Length);
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            // test 12
            //Console.WriteLine(easy.CountAndSay(1));
            //Console.WriteLine(easy.CountAndSay(2));
            //Console.WriteLine(easy.CountAndSay(3));
            //Console.WriteLine(easy.CountAndSay(4));
            //Console.WriteLine(easy.CountAndSay(5));
            //Console.WriteLine(easy.CountAndSay(6));

            // test 13
            //int[] n = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            //Console.WriteLine(easy.MaxSubArray(n));

            // test 14
            string s1 = "Hello World";
            string s = "a ";
            string s3 = "";
            string s2 = "b   a    ";
            Console.WriteLine(easy.LengthOfLastWord(s));

            Console.ReadLine();
        }
    }
}
