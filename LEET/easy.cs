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

        public static int[] TwoSum2(int[] nums, int target)
        {
            var lookup = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (lookup.ContainsKey(target - num))
                {
                    var lookupIndex = lookup[target - num];

                    var smallerIndex = i < lookupIndex ? i : lookupIndex;
                    var largerIndex = i > lookupIndex ? i : lookupIndex;
                    return new int[] { smallerIndex, largerIndex };
                }
                else
                {
                    lookup[num] = i;
                }
            }

            // Should never get here
            return null;
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
                if (i == s.Length - 1 || roman[s[i]] >= roman[s[i + 1]])
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

            int integer = roman[s[s.Length - 1]];
            for (int i = s.Length - 2; i >= 0; i--)
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
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] != nums[i + 1]) nums[++j] = nums[i + 1];
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
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j]) break;
                    if (j == needle.Length - 1) return i;
                }
            }
            // nothing same come here
            return -1;
        }
        /* Given a sorted array and a target value, 
         * return the index if the target is found. 
         * If not, return the index where it would be 
         * if it were inserted in order.
         * 
         */
        public static int SearchInsert(int[] nums, int target)
        {
            int n = nums.Length, i = 0;
            while (i < n)
            {
                if (nums[i] >= target) break;
                i++;
            }
            return i;
        }
        /* The count-and-say sequence is the sequence of integers with 
         * the first five terms as following:
                    1.     1
                    2.     11
                    3.     21
                    4.     1211
                    5.     111221
         * 1 is read off as "one 1" or 11.
         * 11 is read off as "two 1s" or 21.
         * 21 is read off as "one 2, then one 1" or 1211.
         * Given an integer n, generate the nth term of the count-and-say 
         * sequence. 
         * Note: Each term of the sequence of integers will be represented as a
         * string. 
         */
        public static string CountAndSay(int n)
        {

            string s = "";
            for (int i = 0; i < n; i++)
            {
                s = nextSequence(s);
            }
            return s;
        }
        static string nextSequence(string s)
        {
            string new_s = "";
            if (s == null || s == "")
                return new_s = "1";
            char digit = s[0];
            int j = 0, count = 0; ;
            while (j < s.Length)
            {
                if (s[j] != digit)
                {
                    new_s = new_s + count.ToString() + digit;
                    digit = s[j];
                    count = 1;
                }
                else
                    count++;
                j++;
            }
            return new_s + count.ToString() + digit;
        }

        /* Find the contiguous subarray within an array 
         * (containing at least one number) which has the largest sum. 
         * For example, given the array [-2,1,-3,4,-1,2,1,-5,4],
         * the contiguous subarray [4,-1,2,1] has the largest sum = 6. 
         * !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
         */
        public static int MaxSubArray(int[] nums)
        {
            int n = nums.Length;
            int sum = nums[0];
            int sumnext = nums[0];
            for (int i = 1; i < n; i++)
            {
                sumnext = Math.Max(sumnext + nums[i], nums[i]);
                sum = Math.Max(sum, sumnext);
            }
            return sum;
        }
        public static int MaxSubArray2(int[] nums)
        {
            int n = nums.Length;
            int sum = nums[0];
            int sumnext = nums[0];
            for (int i = 1; i < n; i++)
            {
                if (sumnext < 0)
                    sumnext = nums[i];
                else
                    sumnext += nums[i];
                sum = Math.Max(sum, sumnext);
            }
            return sum;
        }
        /* 80 ms
         * 100% Ah-ha-ha
         */
        public static int LengthOfLastWord(string s)
        {
            if (s == "") return 0;
            string[] lasts = s.Split();
            int i = lasts.Length - 1;
            string last = lasts[i].ToLower();
            while (--i >= 0 && last == "")
            {
                last = lasts[i].ToLower();
            }
            for (int j = 0; j < last.Length; j++)
            {
                if (last[j] <= 'a' && last[j] >= 'z')
                    return 0;
            }
            return last.Length;
        }
        public static int LengthOfLastWord2(string s)
        {
            var results = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();

            return results == null ? 0 : results.Length;
        }
        public static int[] PlusOne(int[] digits)
        {
            List<int> di = new List<int>(digits);
            int n = digits.Length;
            di[--n]++;
            while (--n >= 0 && di[n + 1] > 9)
            {
                di[n + 1] -= 10;
                di[n]++;
            }
            if (di[0] > 9)
            {
                di[0] -= 10;
                di.Insert(0, 1);
            }
            return di.ToArray();
        }
        public static string AddBinary(string a, string b)
        {
            char[] a1 = numstr2char(a);
            char[] b1 = numstr2char(b);
            List<char> result = new List<char>();
            List<char> output = new List<char>();
            int n = a1.Length;
            int m = b1.Length;
            int carry = 0, i = 1, t;
            do
            { // 循环变量没自增，嗯，是我能犯的错
                if (i <= n && i <= m)
                    t = a1[n - i] + b1[m - i] + carry;
                else if (i <= n)
                    t = a1[n - i] + carry;
                else if (i <= m)
                    t = b1[m - i] + carry;
                else
                    t = carry; // can't reach here.
                result.Add((char)(t % 2));
                carry = t / 2;
                i++;
            } while (i <= n || i <= m);
            if (carry != 0) result.Add((char)carry);
            for (int j = result.Count - 1; j >= 0; j--)
            {
                output.Add((char)(result[j]+'0'));
            }
            string o = new string(output.ToArray());
            return o;
        }
        private static char[] numstr2char(string s)
        {
            char[] c = s.ToCharArray();
            for (int i=0; i < c.Length; i++)
            { // '0' - 48
                c[i] -= (char)48;
            }
            return c;
        }
        /* int相乘溢出
         * 超出时间限制
         */
        public static int MySqrt(int x)
        {
            long m = 0, n = x, i, a1, a2;
            //if (x == 1) return 1;
            do
            {
                i = (m + n) / 2;
                a1 = i * i;
                a2 = (i + 1) * (i + 1);
                if (a1 > x)
                    n = i;
                else if (a2 <= x)
                    m = i + 1;
                else if ((a1 <= x) && (a2 > x)) break;
            } while (true);
            return (int)i;
        }
        /* 溢出怎么处理，
         * 思路简单，头铁，错误
         */
        public static int ClimbStairs(int n)
        {
            // all one.
            int n_one = n;
            int n_two = 0;
            int count = 1;
            do
            {
                if ((n_one -= 2) < 0) break;
                else
                {
                    n_two++;
                    count += combinatorics(n_one + n_two, Math.Min(n_one, n_two));
                }
            }
            while (true);
            return count;
        }
        private static int combinatorics(int n, int k)
        {
            if (k == 0) return 1;
            ulong nn = 1,kk = 1;
            for(uint i = (uint)(n-k+1); i <= n; i++)
            {
                nn *= i; 
            }
            for(uint j = (uint)k; j > 1; j--)
            {
                kk *= j;
            }
            return (int)(nn / kk);
        }

        /* 动态规划
         * ways[n]只与ways[n-1]和ways[n-2]有关 得到这个前提是关键
         * 为什么
         */
        public static int ClimbStairs2(int n)
        {
            List<uint> ways = new List<uint>() { 1, 1};
            for (int i = 1; i < n; i++)
            {
                uint temp = ways[1];
                ways[1] += ways[0];
                ways[0] = temp;
            }
            return (int)ways[1];
        }
    }
}
