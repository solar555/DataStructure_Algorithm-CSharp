using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class Program
    {
        static int[] arr;

        static void Main(string[] args)
        {
            arr = new int[100];
            Random rnd = new Random(100);
            for (int i = 0; i < 100; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }


        }

        /// <summary>
        /// 顺序查找
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="sValue"></param>
        /// <returns></returns>
        static int SeqSearch(int[] arr, int sValue)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == sValue)
                {
                    swap(i, i - 1);
                    return i;
                }
            }
            return -1;
        }

        static void swap(int item1, int item2)
        {
            int temp = arr[item1];
            arr[item1] = arr[item2];
            arr[item2] = temp;
        }

        /// <summary>
        /// 查找最小值
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        /// <summary>
        /// 查找最大值
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int FinMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        /// <summary>
        /// 二叉查找
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int binSearch(int value)
        {
            int upperBound, lowerBound, mid;
            upperBound = arr.Length - 1;
            lowerBound = 0;
            while (lowerBound <= upperBound)
            {
                mid = (upperBound + lowerBound) / 2;
                if (arr[mid] == value)
                    return mid;
                else
                {
                    if (value < arr[mid])
                        upperBound = mid - 1;
                    else
                        lowerBound = mid + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// 递归二叉查找
        /// </summary>
        /// <param name="value"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public int RbinSearch(int value, int lower, int upper)
        {
            if (lower > upper)
                return -1;
            else
            {
                int mid;
                mid = (upper + lower) / 2;
                if (value < arr[mid])
                    return RbinSearch(value, lower, mid - 1);
                else if (value == arr[mid])
                    return mid;
                else
                    return RbinSearch(value, mid + 1, upper);

            }
        }

        public int Bsearch(int value)
        {
            return Array.BinarySearch(arr, value);
        }
    }
}
