﻿using System;
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

    }
}