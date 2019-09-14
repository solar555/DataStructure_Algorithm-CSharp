using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 实例化示例
            //KeyValuePair<string, int> mcmillan = new KeyValuePair<string, int>("McMillan", 99);
            //Console.WriteLine(mcmillan.Key);
            //Console.WriteLine(" " + mcmillan.Value);

            // 2. 实现一个成绩簿
            KeyValuePair<string, int>[] gradeBook = new KeyValuePair<string, int>[10];
            gradeBook[0] = new KeyValuePair<string, int>("McMillan", 99);
            gradeBook[1] = new KeyValuePair<string, int>("Ruff", 64);
            for (int i = 0; i <= gradeBook.GetUpperBound(0); i++)
                if (gradeBook[i].Value != 0)
                    Console.WriteLine(gradeBook[i].Key + ": " + gradeBook[i].Value);

            Console.Read();
        }
    }
}
