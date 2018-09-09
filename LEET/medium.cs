using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEET
{
    public class medium
    {
        /*You are given two non-empty linked lists representing two 
         * non-negative integers. 
         * The digits are stored in reverse order and each of 
         * their nodes contain a single digit. 
         * Add the two numbers and return it as a linked list.
         * You may assume the two numbers do not contain any leading zero, 
         * except the number 0 itself.
         */
        static bool isTen;
        static bool checkTen(ref easy.ListNode l)
        {
            if (l.val > 9)
            {
                l.val %= 10;
                isTen = true;
                
            }
            else isTen = false;
            return isTen;
        }
        public static easy.ListNode AddTwoNumbers(easy.ListNode l1, easy.ListNode l2)
        {
            {
                if (l1 == null && l2 == null)
                    if (isTen)
                    {
                        isTen = false;
                        return new easy.ListNode(1);
                    }
                    else return null;
                if (l1 == null)
                {
                    if (isTen)
                    {
                        l2.val++;
                        if (checkTen(ref l2))
                            l2.next = AddTwoNumbers(new easy.ListNode(0), l2.next);
                    }
                    return l2;
                }
                if (l2 == null)
                {
                    if (isTen)
                    {
                        l1.val++;
                        if (checkTen(ref l1))
                            l1.next = AddTwoNumbers(new easy.ListNode(0), l1.next);
                    }
                    return l1;
                }
                l1.val = (isTen)?(l1.val+l2.val+1):(l1.val+l2.val);
                checkTen(ref l1);
                l1.next = AddTwoNumbers(l1.next, l2.next);
                return l1;
            }
        }
        // others'
        public static easy.ListNode AddTwoNumbers2(easy.ListNode l1, easy.ListNode l2)
        {
            easy.ListNode head = new easy.ListNode(-1);
            easy.ListNode node = head;
            int sum = 0;
            int carry = 0;
            long count = 0;
            while (l1 != null && l2 != null)
            {

                sum = l1.val + l2.val + carry;
                carry = sum / 10;
                if (carry != 0)
                    sum = sum % 10;
                l1 = l1.next;
                l2 = l2.next;
                if (count == 0)
                {
                    head.val = sum;
                    //head = node;
                    count++;
                }
                else
                {
                    node.next = new easy.ListNode(sum);
                    node = node.next;
                }
            }

            while (l1 != null)
            {
                sum = l1.val + carry;
                carry = sum / 10;
                if (carry != 0)
                    sum = sum % 10;
                node.next = new easy.ListNode(sum);
                node = node.next;
                l1 = l1.next;
            }

            while (l2 != null)
            {
                sum = l2.val + carry;
                carry = sum / 10;
                if (carry != 0)
                    sum = sum % 10;
                node.next = new easy.ListNode(sum);
                node = node.next;
                l2 = l2.next;
            }

            if (carry != 0)
            {
                node.next = new easy.ListNode(carry);
            }

            return head;
        }
        /* time limit exceeded
         * Brute Force 暴力算法
         */
        public static int LengthOfLongestSubstring2(string s)
        {
            string l = "";
            string o = "";
            for (int i = 0; i < s.Length; i++)
            { // change: 不要重复循环，已经判定不重复的字符串序列可以重用.
                for (int j = i; j < s.Length; j++)
                {
                    if (containChar(l, s[j]) != -1) l += s[j];
                    else
                    {
                        // if (l.Length > o.Length) o = new string(l.ToCharArray());
                        if (l.Length > o.Length) o = l;
                        l = "";
                        break;
                    }
                }
            }
            if (l != "")
                if (l.Length > o.Length)
                    o = l;
            return o.Length;
        } 
        // 不知不觉用了窗口滑动 sliding window 还优化了
        public static int LengthOfLongestSubstring3(string s)
        {
            string l = "";
            string o = "";
            for (int i = 0; i < s.Length; i++)
            {
                int j = containChar(l, s[i]);
                if ( j == -1) l += s[i];
                else
                {
                    if (l.Length > o.Length) o = l;
                    l = l.Remove(0, j);
                    i--;
                }
            }
            // 没必要算完
            if (l != "")
                if (l.Length > o.Length)
                    o = l;
            return o.Length;
        }
        public static int containChar(string l, char c)
        {
            for (int i = 0; i < l.Length; i++)
            {
                if (l[i] == c) return i + 1;
            }
            return -1;
        }
        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            List<char> o = new List<char>(); // use HashSet instead of List.
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                if (!o.Contains(s[j]))
                {
                    o.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    o.Remove(s[i++]);
                }
            }
            return ans;
        }
        // use Dictionary (or HashMap)
        //public static int LengthOfLongestSubstring(string s)
        //{
        //    int n = s.Length, ans = 0;
        //    Dictionary<char, int> d = new Dictionary<char, int>();
        //    for (int i = 0, j = 0; j < n; j++)
        //    {
        //        if (d.ContainsKey(s[j]))
        //            i = Math.Max(d[s[j]], i);
        //        ans = Math.Max(ans, j - i + 1);
        //        d.Add(s[j], j + 1);
        //    }
        //    return ans;
        //}
        public int LengthOfLongestSubstring_(string s)
        {
            int[] lastInd = new int[256];
            for (int i = 0; i < 256; i++)
                lastInd[i] = -1;
            int start = -1;
            int res = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (lastInd[s[i]] > start)
                    start = lastInd[s[i]];
                lastInd[s[i]] = i;
                res = Math.Max(res, i - start);
            }
            return res;
        }

        public static string SimplifyPath(string path)
        {
            Stack<string> S = new Stack<string>();
            string[] Strs = path.Split('/');
            for (int i = 0; i < Strs.Length; i++)
            {
                if ("" == Strs[i] || "." == Strs[i])
                    continue;
                else if (".." == Strs[i])
                {
                    if (S.Count != 0)
                        S.Pop();
                }
                else
                    S.Push(Strs[i]);
            }
            string ans = S.Count == 0 ? "/" : ("/" + S.Pop());
            string temp = "";
            while (S.Count > 0)
            {
                temp = "/" + S.Pop();
                ans = temp + ans;
            }
            return ans;
        }

        public static string LongestPalindrome(string s)
        {
            if (s.Length == 0) { return ""; }
            int i = 0, w = s.Length;
            string ans = "";
            for (; w > 1; w--)
            {
                for (i = 0; i <= s.Length - w; i++)
                {
                    if (isPalindrome(s, i, w) == true)
                    {
                        for (int j = i; j < i + w; j++)
                        {
                            ans += s[j];
                        }
                        return ans;
                    }
                }
            }
            ans += s[0];
            return ans;
        }
        private static bool isPalindrome(string s, int start, int window)
        {
            int end = start + window;
            for (int i = 0; i < window; i++)
            {
                if (i < (end - i))
                {
                    if (s[i + start] != s[end - i - 1])
                        return false;
                }
                else
                    break;
            }
            return true;
        }
        // Manacher's algorithm (find longest Palindrome)
        private static string preProcess(string s)
        {
            int n = s.Length;
            if (n == 0) return "^$";
            string ret = "^";
            for (int i = 0; i < n; i++)
            {
                ret += "#" + s[i];
            }
            ret += "#$";
            return ret;
        }
        public static string LongestPalindrome2(string s)
        {
            string T = preProcess(s);
            int n = T.Length;
            int[] P = new int[n]; // the length of the palindrome centers at Ti.
            int C = 0, R = 0;
            for (int i = 1; i < n - 1; i++)
            {
                int i_mirror = 2 * C - i; // C - (i - C);
                P[i] = (R > i) ? Math.Min(R-i, P[i_mirror]) : 0;

                // Attempt to expand palindrome centered at i
                while (T[i + 1 + P[i]] == T[i - 1 - P[i]])
                    P[i]++;

                if (i + P[i] > R)
                {
                    C = i;
                    R = i + P[i];
                }
            }
            int maxLen = 0;
            int centreIndex = 0;
            for (int i = 1; i < n-1; i++)
            {
                if (P[i] > maxLen)
                {
                    maxLen = P[i];
                    centreIndex = i;
                }
            }
            return s.Substring((centreIndex-maxLen-1)/2, maxLen);
        }

    }
}
