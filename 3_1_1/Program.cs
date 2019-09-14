using _1_5_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Timing sortTime = new Timing();
            Random rnd = new Random(100);
            int numItems = 10000;
            CArray theArray = new CArray(numItems);
            theArray.AllowPrint = false;
            for (int i = 0; i < numItems; i++)
            {
                theArray.Insert(rnd.Next(0,100));
            }

            sortTime.StartTime();
            theArray.SelectionSort();
            sortTime.StopTime();
            Console.WriteLine("time for selectionSort: " + sortTime.Result().TotalMilliseconds);
            theArray.Clear();

            for (int i = 0; i < numItems; i++)
            {
                theArray.Insert(rnd.Next(0, 100));
            } 
            sortTime.StartTime();
            theArray.BubbleSort();
            sortTime.StopTime();
            Console.WriteLine("time for BubbleSort: " + sortTime.Result().TotalMilliseconds);
            theArray.Clear();

            for (int i = 0; i < numItems; i++)
            {
                theArray.Insert(rnd.Next(0, 100));
            }
            sortTime.StartTime();
            theArray.InsertionSort();
            sortTime.StopTime();
            Console.WriteLine("time for InsertSort: " + sortTime.Result().TotalMilliseconds);

            Console.Read();
        }
    }
}
