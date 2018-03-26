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
    }
}
