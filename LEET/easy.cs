using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEET
{
    public class easy
    {
        /* Given an array of integers, return indices of the two numbers
         * such that they add up to a specific target.
         * input: nums: the array of integers
         *        target: the specific target
         * output: the index in the array
         */
        public static int[] twoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == target - nums[j])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            //throw new IllegalArgumentException("No two sum solution");
            return new int[] { 0 };
        }

        /* Reverse Integer: Given a 32-bit signed integer, reverse
         * digits of the integer.
         * note: the function returns 0 when the reversed integer
         * overflows.
         * input: the given 32-bit signed integer
         * output： the reversed integer
         */
        public static int Reverse(int x)
        {
            int result = 0;

            while (x != 0)
            {
                int tail = x % 10;
                int newResult = result * 10 + tail;
                // for what? 判断 result * 10 后，是否溢出
                if ((newResult - tail) / 10 != result)
                {
                    return 0;
                }
                result = newResult;
                x = x / 10;
            }
            return result;
        }
        public static int Reverse3(int x)
        {
            // 使用链表反向 （内置 LinkedList） 
            int result = 0;
            return result;
        }
        /* Determine whether an integer is a palindrome. 
         * Do this without extra space.
         * 312 ms -> 104 ms
         * 
         */
        public static bool IsPalindrome(int x)
        {
            // if (x < 0)
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;
            else
            {
                string str = x.ToString();
                for (int i = 0; i < str.Length; i++)
                {
                    if (str.Length - i > i)
                    {
                        if (str[i] != str[str.Length - i - 1])
                            return false;
                    }
                    else break;
                }
            }
            return true;
        }
        
        /* Given a roman numeral, convert it to an integer.
         * Input is guaranteed to be within the range from 1 to 3999.
         * 240 ms
         */
        public static int RomanToInt(string s)
        {
            Dictionary<char,int> roman = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };
            //roman.Add('I', 1);
            //roman.Add('V', 5);
            //roman.Add('X', 10);
            //roman.Add('L', 50);
            //roman.Add('C', 100);
            //roman.Add('D', 500);
            //roman.Add('M', 1000);
            int integer = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1 || roman[s[i]] >= roman[s[i+1]])
                    integer += roman[s[i]];
                else
                    integer -= roman[s[i]];
            }
            return integer;
        }
        // 192 ms
        public static int RomanToInt2(string s)
        {
            Dictionary<char, int> roman = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            int integer = roman[s[s.Length-1]];
            for (int i = s.Length-2; i >= 0; i--)
            {
                if (roman[s[i]] < roman[s[i + 1]])
                    integer -= roman[s[i]];
                else
                    integer += roman[s[i]];
            }
            return integer;
        }

        // 192 ms
        public static int RomanToInt3(string s)
        {
            int[] nums = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'M':
                        nums[i] = 1000;
                        break;
                    case 'D':
                        nums[i] = 500;
                        break;
                    case 'C':
                        nums[i] = 100;
                        break;
                    case 'L':
                        nums[i] = 50;
                        break;
                    case 'X':
                        nums[i] = 10;
                        break;
                    case 'V':
                        nums[i] = 5;
                        break;
                    case 'I':
                        nums[i] = 1;
                        break;
                }
            }
            int sum = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                    sum -= nums[i];
                else
                    sum += nums[i];
            }
            return sum + nums[nums.Length - 1];
        }
        // 124 ms
        public static int RomanToInt4(string s)
        {
            Dictionary<char, int> roman = new Dictionary<char, int>()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            //int integer = roman[s[s.Length - 1]];
            int integer = 0;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (i < s.Length - 1)
                    if (roman[s[i]] < roman[s[i + 1]])
                    {
                        integer += roman[s[i + 1]] - roman[s[i]];
                        i++;
                    }
                    else
                        integer += roman[s[i]];
                else
                    integer += roman[s[i]];
            }
            return integer;
        }

        /* Write a function to find the longest common prefix string amongst
         * an array of strings. 
         * 
         * 136ms
         */
        public static string LongestCommonPrefix(string[] strs)
        {
            //if (strs == null) return null;
            if (strs == null || strs.Length == 0) return "";
            String prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {

                //while (!strs[i].Contains(prefix))
                //{
                //    prefix = prefix.Remove(prefix.Length - 1, 1);
                //    if (prefix == "") return "";
                //}
                //for (int j = 0; j < prefix.Length; j++)
                //{
                //    if (prefix[j] == strs[i][j]) continue;
                //    prefix = prefix.Remove(j, prefix.Length - j);
                //    break;
                //}
                int j;
                for (j = 0; j < prefix.Length && j < strs[i].Length; j++)
                {
                    if (prefix[j] != strs[i][j]) break;
                }
                int toRemove = prefix.Length - j;
                if (toRemove > 0)
                {
                    prefix = prefix.Remove(j, toRemove);
                }
            }
            return prefix;
        }

        /* Given a string containing just the characters
         * '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
         * The brackets must close in the correct order, 
         * "()" and "()[]{}" are all valid but "(]" and "([)]" are not.
         * 
         * 100ms
         */
        public static bool IsValid(string s)
        {
            const string c_s = "([{";
            const string c_e = ")]}";
            Stack<Char> c = new Stack<char>();
            if (s == null || s == "" || s.Length % 2 == 1) return false;
            if (c_s.Contains(s[0])) c.Push(s[0]);
            else return false;
            for (int i = 1; i < s.Length; i++)
            {
                if (c_s.Contains(s[i])) c.Push(s[i]);
                else if (c_e.Contains(s[i]))
                {
                    if (c_s.IndexOf(c.Pop()) != c_e.IndexOf(s[i]))
                        return false;
                }
            }
            if (c.Count != 0)
                return false;
            return true;
        }

        public bool IsValid2(string s)
        {
            Stack<char> myStack = new Stack<char>();
            char strStack = new char();
            const string c_s = "([{";
            const string c_e = ")]}";
            for (int i = 0; i < s.Length; i++)
            {
                // (s[i] == '(') || (s[i] == '[') || (s[i] == '{') is faster than this (88 ms)
                if (c_s.Contains(s[i])) // 96 ms
                {
                    myStack.Push(s[i]);
                }
                else
                {
                    if (myStack.Count > 0)
                    {
                        strStack = (char)myStack.Pop();
                    }

                    //((strStack == '(' && s[i] == ')') ||
                    //    (strStack == '[' && s[i] == ']') ||
                    //    (strStack == '{' && s[i] == '}')) == false
                    // 88 ms
                    if (c_s.IndexOf(strStack) != c_e.IndexOf(s[i])) // 96 ms
                    {
                        return false;
                    }
                }
            }

            return (myStack.Count == 0);
        }

        /* Merge two sorted linked lists and return it as a new list. 
         * The new list should be made by splicing together the nodes 
         * of the first two lists.
         * 
         */
        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }

        /* Given a sorted array, remove the duplicates in-place such that 
         * each element appear only once and return the new length.
         * Do not allocate extra space for another array, 
         * you must do this by modifying the input array in-place 
         * with O(1) extra memory.
         * 
         * 数组引用类型，在函数内修改的是传入参数调用的变量。
         */
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            int j = 0;
            for (int i = 0; i<nums.Length-1; i++)
            {
                if (nums[i] != nums[i + 1]) nums[++j] = nums[i+1];
            }
            return ++j;
        }

        /* Given an array and a value, remove all instances of 
         * that value in-place and return the new length.
         * Do not allocate extra space for another array, 
         * you must do this by modifying the input array in-place 
         * with O(1) extra memory.
         * The order of elements can be changed. 
         * It doesn't matter what you leave beyond the new length.
         */
        public static int RemoveElement(int[] nums, int val)
        {
            if (nums == null || nums.Length == 0) return 0;
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (val != nums[i]) nums[j++] = nums[i];
            }
            return j;
        }

        /* Return the index of the first occurrence of needle in haystack, 
         * or -1 if needle is not part of haystack. 
         */
        public static int StrStr(string haystack, string needle)
        {
            //return haystack.IndexOf(needle);
            if (haystack == null || needle == null) return -1;
            if (haystack.Length < needle.Length) return -1;
            if (needle == "") return 0;
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack.Length - i < needle.Length) return -1;
                if (haystack[i] != needle[0]) continue;
                for (int j = 0; j < needle.Length; j++){
                    if (haystack[i + j] != needle[j]) break;
                    if (j == needle.Length - 1) return i;
                }
            }
            // nothing same come here
            return -1;
        }
    }
}
