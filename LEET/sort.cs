using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEET
{
    
    public class sort
    {
        private static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static int[] bubble_sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                        swap(ref array[j], ref array[j + 1]);
                }
            }
            return array; 
        }

        public static int[] bubble_sort_withflag(int[] array)
        {
            bool flag;
            for (int i = 0; i < array.Length - 1; i++)
            {
                flag = false;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swap(ref array[j], ref array[j + 1]);
                        flag = true;
                    }
                }
                if (flag == false) break;
            }
            return array;
        }

        public static int[] cocktail_sort (int[] array)
        {
            int left = 0, right = array.Length - 1;
            while(left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                        swap(ref array[i], ref array[i + 1]);
                }
                right--;
                for (int j = right; j > left; j--)
                {
                    if (array[j] < array[j - 1])
                        swap(ref array[j], ref array[j - 1]);
                }
                left++;
            }
            return array;
        }
        public static int[] cocktail_sort_withflag (int[] array)
        {
            int left = 0, right = array.Length - 1;
            bool flag;
            while (left < right)
            {
                flag = false;
                for (int i = left; i < right; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        swap(ref array[i], ref array[i + 1]);
                        flag = true;
                    }
                }
                right--;
                for (int j = right; j > left; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        swap(ref array[j], ref array[j - 1]);
                        flag = true;
                    }
                }
                left++;
                if (flag == false) break;
            }
            return array;
        }

        public static int[] selection_sort(int[] array)
        {
            int min;
            for (int i = 0; i < array.Length-1; i++)
            {
                min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                }
                swap(ref array[i], ref array[min]);
            }
            return array;
        }

        public static int[] insertion_sort(int[] array)
        {
            int i, j;
            int temp;
            for (i = 1; i < array.Length; i++)
            {
                temp = array[i];
                for (j = i; j > 0 && array[j-1] > temp; j--)
                {
                    array[j] = array[j - 1];
                }
                array[j] = temp;
            }
            return array;
        }

        public static int[] shell_sort(int[] array)
        {
            int step, i, j;
            int temp;
            for (step = array.Length >> 1; step > 0; step >>= 1)
            {
                for (i = step; i < array.Length; i++)
                {
                    temp = array[i];
                    for (j = i; j >= step && array[j - step] > temp; j -= step)
                    {
                        array[j] = array[j - step];
                    }
                    array[j] = temp;
                }
                for (int k = 0; k < array.Length; k++)
                    Console.Write($"{array[k]} ");
                Console.WriteLine();
            }
            return array;
        }

        public static int[] quick_sort(int[] array)
        {
            quick_sort_recursive(array, 0, array.Length-1);
            return array;
        }

        private static void quick_sort_recursive(int[] array, int left, int right)
        {
            if (right > left)
            {
                int l = left, r = right, cur = right;
                int pivot = array[right];
                //Console.WriteLine(pivot);
                while (l < r)
                {
                    while (l < r && array[l] < pivot) l++;
                    while (l < r && array[r] >= pivot) r--;
                    array[cur] = array[l];
                    array[l] = array[r];
                    cur = r;
                }
                array[cur] = pivot;
                //for (int k = 0; k < array.Length; k++)
                //    Console.Write($"{array[k]} ");
                //Console.WriteLine();
                quick_sort_recursive(array, left, cur - 1);
                quick_sort_recursive(array, cur + 1, right);
            }
        }

        public static void merge_sort(int[] array)
        {
            int[] temp = new int[array.Length];
            merge_sort_recursive(array, temp, 0, array.Length - 1);
        }
        private static void merge_sort_recursive(int[] array, int[] temp, int left, int right)
        {
            if (left >= right) return;
            int mid = ((right - left) >> 1) + left; // >> 和 + 的运算优先级
            int l1 = left, l2 = mid + 1, r1 = mid, r2 = right;
            merge_sort_recursive(array, temp, l1, r1);
            merge_sort_recursive(array, temp, l2, r2);
            int k = left;
            while (l1 <= r1 && l2 <= r2)
            {
                temp[k++] = (array[l1] < array[l2]) ? array[l1++] : array[l2++];
            }
            while (l1 <= r1)
            {
                temp[k++] = array[l1++];
            }
            while (l2 <= r2)
            {
                temp[k++] = array[l2++];
            }
            for (k = left; k <= right; k++)
            {
                array[k] = temp[k];
            }
        }

        public static void merge_sort2(int[] array)
        {
            int[] temp = new int[array.Length];
            int end = array.Length - 1;
            for (int len = 1; len < array.Length; len += len)
            {
                for (int left = 0; left < array.Length; left += len + len )
                {
                    int mid = Math.Min(end, left + len);
                    int right = Math.Min(end, left + len + len - 1);
                    int l1 = left, r1 = mid - 1;
                    int l2 = mid, r2 = right;
                    int i = left;
                    while (l1 <= r1 && l2 <= r2)
                        temp[i++] = (array[l1] < array[l2]) ? array[l1++] : array[l2++];
                    while (l1 <= r1)
                        temp[i++] = array[l1++];
                    while (l2 <= r2)
                        temp[i++] = array[l2++];
                    for (i = left; i <= right; i++)
                        array[i]= temp[i];
                }
            }
        }

        public static void heap_sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2; i >= 0; i--)
                max_heapify(arr, i, n - 1);
            for (int i = n - 1; i > 0; i--)
            {
                swap(ref arr[0], ref arr[i]);
                max_heapify(arr, 0, i - 1);
            }
        }

        private static void max_heapify(int[] arr, int start, int end)
        {
            int parent = start;
            int child = 2 * parent + 1;
            while(child <= end)
            {
                if (child + 1 < end && arr[child] < arr[child + 1])
                    child++;
                if (arr[parent] > arr[child])
                    return;
                else
                {
                    swap(ref arr[parent], ref arr[child]);
                    parent = child;
                    child = 2 * parent + 1;
                }
            }
        }

        public static void heap_sort2(int[] arr)
        {
            int size = arr.Length - 1;
            build_heap(arr, size);
            for (int i = size; i > 0; i--)
            {
                swap(ref arr[0], ref arr[i]);
                size--;
                sift_down(arr, 0, size);
            }
        }

        private static void build_heap(int[] arr, int size)
        {
            for (int i = size / 2; i >= 0; i--)
            {
                sift_down(arr, i, size);
            }
        }

        private static void sift_down(int[] arr, int i, int size)
        {
            int child = 2 * i + 1;
            int maxIndex = i;
            if (child < size && arr[maxIndex] < arr[child])
                maxIndex = child;
            if (child + 1 < size && arr[maxIndex] < arr[child + 1])
                maxIndex = child + 1;
            if (i != maxIndex)
            {
                swap(ref arr[maxIndex], ref arr[i]);
                sift_down(arr, maxIndex, size);
            }
        }

        public static int[] counting_sort(int[] arr)
        {
            // only sort 0 ~ k elements.
            int m = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > m) m = arr[i];
            }
            int[] result = new int[arr.Length];
            int[] counts = new int[m+1];
            for (int i = 0; i <= m; i++) counts[i] = 0;
            for (int i = 0; i < arr.Length; i++) counts[arr[i]]++;
            for (int i = 1; i <= m; i++) counts[i] += counts[i - 1];
            for (int i = arr.Length - 1; i >= 0; i--)
                result[--counts[arr[i]]] = arr[i];
            return result;
        }
    }
}
