using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEET
{
    public class hard
    {
        //太扯了……
        //public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        //{
        //    double m1 = 0, m2 = 0;
        //    int d = 0;
        //    if (nums1.Length != 0)
        //    {
        //        m1 = Median(nums1);
        //        d++;
        //    }
        //    if (nums2.Length != 0)
        //    {
        //        m2 = Median(nums2);
        //        d++;
        //    }
        //    double ans = (m1 + m2) / d;
        //    return ans;
        //}
        //private static double Median(int[] nums)
        //{
        //    int n = nums.Length;
        //    int index = n/2;
        //    if (n % 2 == 0)
        //    {
        //        return (nums[index] + nums[index - 1]) / 2.0;
        //    }
        //    else
        //    {
        //        return nums[index];
        //    }
        //}
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int N = nums1.Length + nums2.Length;
            int[] nums = new int[N];
            double ans = 0;
            int index = N / 2;
            // valid, not both empty
            if (nums1.Length == 0)
            {
                nums = nums2;
            }
            else if (nums2.Length == 0)
            {
                nums = nums1;
            }
            else
            { // merge
                int i = 0, j = 0, n = 0;
                
                while (i < nums1.Length && j < nums2.Length)
                {
                    if (nums1[i] < nums2[j])
                        nums[n++] = nums1[i++];
                    else
                        nums[n++] = nums2[j++];
                }
                while (i < nums1.Length)
                    nums[n++] = nums1[i++];
                while (j < nums2.Length)
                    nums[n++] = nums2[j++];
            }
            // find median
            if (N % 2 == 1)
            {
                ans = nums[index];
            }
            else
            {
                ans = (nums[index - 1] + nums[index]) / 2.0;
            }
            return ans;
        }
        // other's method.
        public static double FindMedianSortedArrays2(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0;
            var length = nums1.Length + nums2.Length;

            int prevM = 0, m = 0;

            for (var k = 0; k < length / 2 + 1; k++)
            {
                prevM = m;
                if (j >= nums2.Length || i < nums1.Length && nums1[i] < nums2[j])
                {
                    m = nums1[i++];
                }
                else
                {
                    m = nums2[j++];
                }
            }

            if (length % 2 == 0)
                return (m + prevM) / 2.0;

            return m;
        }

        public static IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<string>> ans = new List<IList<string>>();
            // int count = 0;
            List<int> pos = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                pos.Add(-1);
                //Console.WriteLine(pos[i]);
            }
            int r = 0, c = 0;
            while(r < n)
            {
                while (c < n)
                {
                    if (isValid(r, c, ref pos))
                    {
                        pos[r] = c;
                        c = 0;
                        break;
                    }
                    else
                        c++;
                }
                if (pos[r] == -1)
                {
                    if (r == 0)
                    {
                        break;
                    }
                    else
                    {
                        r--;
                        c = pos[r] + 1;
                        pos[r] = -1;
                        continue;
                    }

                }
                if (r == n - 1)
                {
                    List<string> s = new List<string>();
                    String temp;
                    for (int i = 0; i < n; i++)
                    {
                        temp = "";
                        for (int j = 0; j < n; j++)
                        {
                            temp += (pos[i] == j) ? "Q" : ".";
                        }
                        s.Add(temp);
                    }
                    ans.Add(s);
                    //r = 0;
                    c = pos[r] + 1;
                    pos[r] = -1;
                    //for (int i = 0; i < n; i++)
                    //    pos[i] = -1;
                    continue;
                }
                r++;
            }
            //return (IList<IList<string>>)ans;
            return ans;
        }
        private static bool isValid(int row, int col, ref List<int> pos)
        {
            // row is new, check the col and slash.
            for (int i = 0; i < row + 1; i++)
            {
                if (pos[i] == col || Math.Abs(row - i) == Math.Abs(col - pos[i]))
                    return false;
            }
            return true;
        }
        public static int TotalNQueens(int n)
        {
            IList<IList<string>> ans = new List<IList<string>>();
            ans = SolveNQueens(n);
            return ans.Count;
        }
    }
}
