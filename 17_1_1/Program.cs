using _1_5_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 递归
            //long num = RecurFib(0);
            //Console.WriteLine(num);

            // 2. 动态规划
            //long num = IterFib(7);
            //Console.WriteLine(num);

            // 3. 测试效率
            Timing t1 = new Timing();
            Timing t2 = new Timing();

            int num = 40;
            long fibNumber;

            t1.StartTime();
            fibNumber = RecurFib(num);
            t1.StopTime();
            Console.WriteLine(fibNumber + " in: " + t1.Result().TotalMilliseconds);
            Console.WriteLine();

            t2 = new Timing();
            t2.StartTime();
            //fibNumber = IterFib(num);

            int i = 5;
            t2.StopTime();
            Console.WriteLine(fibNumber + " in: " + t2.Result().TotalMilliseconds);

            Console.ReadKey();
        }

        /// <summary>
        ///  计算斐波那契数列（效率低下的递归算法）
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        static long RecurFib(int index)
        {
            if (index < 2)
                return index;
            else return RecurFib(index - 1) + RecurFib(index - 2);
        }

        static long IterFib(int index)
        {
            int[] val = new int[index + 1];

            if (index == 0)
                return 0;

            if (index == 1 || index == 2)
                return 1;
            else
            {
                val[0] = 0;
                val[1] = 1;// index = 1
                val[2] = 1;// index = 2
                for (int i = 3; i <= index; i++)
                    val[i] = val[i - 1] + val[i - 2];
            }

            return val[index];
        }
    }
}
