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
            for (step = array.Length / 3; step > 0; step /= 3)
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
    }
}
