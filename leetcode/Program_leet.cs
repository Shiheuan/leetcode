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
            //string s1 = "Hello World";
            //string s = "a ";
            //string s3 = "";
            //string s2 = "b   a    ";
            //Console.WriteLine(easy.LengthOfLastWord(s));

            // test 15
            //string s1 = "1111";
            //string s2 = "1";
            //Console.WriteLine(easy.AddBinary(s1, s2));

            // test 16
            //Console.WriteLine(easy.MySqrt(8));
            //Console.WriteLine(easy.MySqrt(25));
            //Console.WriteLine(easy.MySqrt(2147395599));
            //Console.WriteLine(easy.MySqrt(1));
            //Console.WriteLine(easy.MySqrt(9));

            // test 17
            //Console.WriteLine(easy.ClimbStairs(35));
            //Console.WriteLine(easy.ClimbStairs(44));
            //Console.WriteLine(easy.ClimbStairs2(45));

            // test babble sort 

            //int[] array = { 5, 1, 6, 8, 4, 3, 9, 2, 7, 10 };
            //DateTime startTime = DateTime.Now;
            //int[] a = sort.bubble_sort(array);
            //DateTime stopTime = DateTime.Now;
            //for (int i = 0; i < array.Length; i++)
            //    Console.Write($"{array[i]} ");
            //Console.WriteLine();
            //Console.WriteLine($"{stopTime - startTime}");

            // test cocktail sort
            //int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 };
            //int[] a = array;
            //DateTime startTime1 = DateTime.Now;
            //a = sort.cocktail_sort(array);
            //// a = sort.bubble_sort(array);
            //DateTime stopTime1 = DateTime.Now;
            //for (int i = 0; i < array.Length; i++)
            //    Console.Write($"{array[i]} ");
            //Console.WriteLine();
            //Console.WriteLine($"{stopTime1 - startTime1}");

            // test selection sort
            //int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 1 };
            //int[] a = array;
            //DateTime startTime1 = DateTime.Now;
            //a = sort.selection_sort(array);
            //// a = sort.bubble_sort(array);
            //DateTime stopTime1 = DateTime.Now;
            //for (int i = 0; i < array.Length; i++)
            //    Console.Write($"{array[i]} ");
            //Console.WriteLine();
            //Console.WriteLine($"{stopTime1 - startTime1}");

            //int[] array = { 5, 1, 6, 8, 4, 3, 9, 2, 7, 10 };
            //int[] a = array;
            //DateTime startTime1 = DateTime.Now;
            //a = sort.insertion_sort(array);
            //// a = sort.bubble_sort(array);
            //DateTime stopTime1 = DateTime.Now;
            //for (int i = 0; i < array.Length; i++)
            //    Console.Write($"{array[i]} ");
            //Console.WriteLine();
            //Console.WriteLine($"{stopTime1 - startTime1}");


            //int[] array = { 13, 14, 94, 33, 82, 25, 59, 94, 65, 23, 45, 27, 73, 25, 39, 10 };
            //int[] a = array;
            //DateTime startTime1 = DateTime.Now;
            //a = sort.shell_sort(array);
            //// a = sort.bubble_sort(array);
            //DateTime stopTime1 = DateTime.Now;
            //for (int i = 0; i < array.Length; i++)
            //    Console.Write($"{array[i]} ");
            //Console.WriteLine();
            //Console.WriteLine($"{stopTime1 - startTime1}");

            //int[] array = { 13, 14, 94, 33, 82, 25, 59, 94, 65, 23, 45, 27, 73, 25, 39, 10, 130, 140, 940, 330, 802, 250, 509, 904, 605, 230, 450, 207, 703, 250, 390, 100, 103, 104, 904, 303, 820, 205, 509, 9400, 605, 2003, 4005, 207, 703, 20005, 309, 1000, 1232, 1422, 942, 332, 822, 252, 5229, 924, 2625, 2223, 425, 2227, 273, 252, 3912, 10123, 13, 14, 94, 33, 82, 25, 59, 94, 65, 23, 45, 27, 73, 25, 39, 10, 130, 140, 940, 330, 802, 250, 509, 904, 605, 230, 450, 207, 703, 250, 390, 100, 103, 104, 904, 303, 820, 205, 509, 9400, 605, 2003, 4005, 207, 703, 20005, 309, 1000, 1232, 1422, 942, 332, 822, 252, 5229, 924, 2625, 2223, 425, 2227, 273, 252, 3912, 10123, 13, 14, 94, 33, 82, 25, 59, 94, 65, 23, 45, 27, 73, 25, 39, 10, 130, 140, 940, 330, 802, 250, 509, 904, 605, 230, 450, 207, 703, 250, 390, 100, 103, 104, 904, 303, 820, 205, 509, 9400, 605, 2003, 4005, 207, 703, 20005, 309, 1000, 1232, 1422, 942, 332, 822, 252, 5229, 924, 2625, 2223, 425, 2227, 273, 252, 3912, 10123, 13, 14, 94, 33, 82, 25, 59, 94, 65, 23, 45, 27, 73, 25, 39, 10, 130, 140, 940, 330, 802, 250, 509, 904, 605, 230, 450, 207, 703, 250, 390, 100, 103, 104, 904, 303, 820, 205, 509, 9400, 605, 2003, 4005, 207, 703, 20005, 309, 1000, 1232, 1422, 942, 332, 822, 252, 5229, 924, 2625, 2223, 425, 2227, 273, 252, 3912, 10123, 13, 14, 94, 33, 82, 25, 59, 94, 65, 23, 45, 27, 73, 25, 39, 10, 130, 140, 940, 330, 802, 250, 509, 904, 605, 230, 450, 207, 703, 250, 390, 100, 103, 104, 904, 303, 820, 205, 509, 9400, 605, 2003, 4005, 207, 703, 20005, 309, 1000, 1232, 1422, 942, 332, 822, 252, 5229, 924, 2625, 2223, 425, 2227, 273, 252, 3912, 10123, 13, 1400, 94, 33, 82, 25, 59, 94, 65, 23, 45, 27, 73, 25, 39, 10, 130, 140, 940, 330, 802, 250, 509, 904, 605, 230, 450, 207, 703, 250, 390, 100, 1030, 1040, 90040, 303, 820, 205, 509, 9400, 605, 2003, 4005, 207, 703, 20005, 309, 1000, 1232, 1422, 942, 332, 822, 252, 5229, 924, 2625, 2223, 425, 22270, 2730, 2520, 39120, 101230, 605, 2003, 4005, 207, 703, 20005, 309, 1000, 1232, 1422, 942, 332, 822, 252, 5229, 924, 2625, 2223, 425, 2227, 273, 252, 3912, 10123, 13, 14, 94, 33, 82, 25, 59, 94, 65, 23, 45, 27, 73, 25, 39, 10, 130, 140, 940, 330, 802, 250, 509, 904, 605, 230, 450, 207, 703, 250, 390, 100, 103, 104, 904, 303, 820, 205, 509, 9400, 605, 2003, 4005, 207, 703, 20005, 309, 1000, 1232, 1422, 942, 332, 822, 252, 5229, 924, 2625, 2223, 425, 2227, 273, 252, 3912, 10123, 13, 1400, 94, 33, 82, 25, 59, 94, 65, 23, 45, 27, 73, 25, 39, 10, 130, 140, 940, 330, 802, 250, 509, 904, 605, 230, 450, 207, 703, 250, 390, 100, 1030, 1040, 90040, 303, 820, 205, 509, 9400, 605, 2003, 4005, 207, 703, 20005, 309, 1000, 1232, 1422, 942, 332, 822, 252, 5229, 924, 2625, 2223, 425, 22270, 12};
            //int[] a = array;
            //DateTime startTime1 = DateTime.Now;
            //a = sort.quick_sort(array);
            ////a = sort.bubble_sort(array);
            //DateTime stopTime1 = DateTime.Now;
            //for (int i = 0; i < array.Length; i++)
            //    Console.Write($"{array[i]} ");
            //Console.WriteLine();
            //Console.WriteLine($"{stopTime1 - startTime1}");

            // int[] array = { 13, 14, 94, 33, 82, 25, 59, 94, 65, 23, 45, 27, 73, 25, 39, 10 };
            // int[] a = array;
            // DateTime startTime1 = DateTime.Now;
            // //sort.merge_sort(array);
            // //sort.merge_sort2(array);
            // sort.heap_sort2(array);
            // DateTime stopTime1 = DateTime.Now;
            // for (int i = 0; i < array.Length; i++)
            //     Console.Write($"{array[i]} ");
            // Console.WriteLine();
            // Console.WriteLine($"{stopTime1 - startTime1}");

            // test 18
            //int[] a = { -2, -1 };
            //int[] b = { 3 };
            //int[] a = {};
            //int[] b = { 3 };
            //Console.WriteLine(hard.FindMedianSortedArrays(a, b));

            //IList<IList<string>> a = new List<IList<string>>();
            //a = hard.SolveNQueens(5);
            //for (int i = 0; i < a.Count; i++)
            //    for (int j = 0; j < a[i].Count; j++)
            //        Console.WriteLine(a[i][j]);

            // test 19
            //string a = "aa";
            //string b = "aaccccdccc";
            //string c = "";
            //string d = "asvcd";

            //Console.WriteLine(medium.LongestPalindrome2(a));
            //Console.WriteLine(medium.LongestPalindrome2(b));
            //Console.WriteLine(medium.LongestPalindrome2(c));
            //Console.WriteLine(medium.LongestPalindrome2(d));

            // test how to use "call stack".
            //int[] b = { 1, 2, 2, 2, 3, 3, 4 };
            //var a = new easy.ListNode(b[0]);
            //var n = a;
            //for (int i = 1; i < b.Length; i++)
            //{
            //    n.next = new easy.ListNode(b[i]);
            //    n = n.next;
            //}

            //easy.DeleteDuplicates(a);

            //exam.BreakBlock game = new exam.BreakBlock();
            ////game.test_func();
            //game.startGame();

            //exam.Cashapon a = new exam.Cashapon();
            //a.test_func();
            //a.start();

            exam.UpdateClient a = new exam.UpdateClient();
            //a.test_func();
            a.start();

            Console.ReadLine();
        }
    }
}
