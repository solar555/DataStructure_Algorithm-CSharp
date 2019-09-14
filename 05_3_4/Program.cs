using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_4
{
    class Program
    {
        enum DigitType { ones = 1, tens = 10 }

        static void Main(string[] args)
        {
            int[] nums = new int[] { 91, 46, 85, 15, 92, 35, 31, 22 };
            Queue[] numQueue = new Queue[10];
            for (int i = 0; i < 10; i++)
                numQueue[i] = new Queue();

            // First pass sort
            RSort(numQueue, nums, DigitType.ones);
            BuildArray(numQueue, nums);
            Console.WriteLine();
            Console.WriteLine("First pass results: ");
            DisplayArray(nums);

            // Second pass sort
            RSort(numQueue, nums, DigitType.tens);
            BuildArray(numQueue, nums);
            Console.WriteLine();
            Console.WriteLine("Second pass results: ");
            DisplayArray(nums);

            Console.WriteLine();
            Console.WriteLine("Press enter to quit");
            Console.ReadKey();
        }

        static void RSort(Queue[] numQueue, int[] nums, DigitType digitType)
        {
            int qIndex;
            for (int i = 0; i <= nums.GetUpperBound(0); i++)
            {
                if (digitType == DigitType.ones)
                    qIndex = nums[i] % 10;
                else
                    qIndex = nums[i] / 10;

                numQueue[qIndex].Enqueue(nums[i]);
            }
        }

        static void BuildArray(Queue[] numQueue, int[] nums)
        {
            int y = 0;
            for (int x = 0; x <= 9; x++)
            {
                while (numQueue[x].Count > 0)
                {
                    nums[y] = int.Parse(numQueue[x].Dequeue().ToString());
                    y++;
                }
            }
        }

        static void DisplayArray(int[] n)
        {
            for (int i = 0; i <= n.GetUpperBound(0); i++)
                Console.Write(n[i] + " ");
        }
    }
}
