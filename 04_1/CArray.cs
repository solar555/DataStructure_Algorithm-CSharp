using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class CArray
    {
        private double[] arr;
        private int upper;
        private int numElements;
        private bool allowPrint;

        public bool AllowPrint
        {
            get
            {
                return allowPrint;
            }
            set
            {
                allowPrint = value;
            }
        }

        public CArray(int size)
        {
            arr = new double[size];
            upper = size - 1;
            numElements = 0;
        }

        public void Insert(double item)
        {
            arr[numElements] = item;
            numElements++;
        }

        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
            {
                arr[i] = 0;
            }

            numElements = 0;
        }

        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        
        /// <summary>
        /// 冒泡排序
        /// </summary>
        public void BubbleSort()
        {
            double temp;
            for (int outer = upper; outer >= 1; outer--)
            {
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }
                }

                if (allowPrint)
                {
                    this.DisplayElements();
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// 选择排序
        /// </summary>
        public void SelectionSort()
        {
            int min;
            double temp;
            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner <= upper; inner++)
                {
                    if (arr[min] > arr[inner])
                    {
                        min = inner;
                    }
                }

                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;

                if (allowPrint)
                {
                    this.DisplayElements();
                    Console.WriteLine();
                }
            }
        }
       
        /// <summary>
        /// 插入排序
        /// </summary>
        public void InsertionSort()
        {
            int inner;
            double temp;
            for (int outer = 1; outer <= upper; outer++)
            {
                temp = arr[outer];
                inner = outer;
                while (inner > 0 && arr[inner - 1] >=temp)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp;

                if (allowPrint)
                {
                    this.DisplayElements();
                    Console.WriteLine();
                }
            }
        }
    }
}
