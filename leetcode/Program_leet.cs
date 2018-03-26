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
            //int a = easy.Reverse2(-1012);
            //Console.WriteLine($"{-10%3}");
            //Console.WriteLine($"{a}");
            int[] a = { -111, 111, 1232332321 };
            for (int i = 0; i < a.Length; i ++)
            {
                Console.WriteLine($"{a[i]}");
                Console.WriteLine($"{easy.IsPalindrome(a[i])}");
            }
                

            Console.ReadLine();
        }
    }
}
