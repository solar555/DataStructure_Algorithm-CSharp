using _1_5_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3
{
    class Program
    {
        public static object Timing { get; private set; }

        static void Main(string[] args)
        {
            int size = 10000;
            Console.WriteLine();
            for (int i = 0; i <= 3; i++)
            {
                Timing timeSB = new Timing();
                Timing timeST = new Timing();
                timeSB.StartTime();
                BuildSB(size);
                timeSB.StopTime();

                timeST.StartTime();
                BuildST(size);
                timeST.StopTime();

                Console.WriteLine("Time to build sb object for " + size + " elements: " + timeSB.Result().TotalMilliseconds);
                Console.WriteLine("Time to build st object for " + size + " elements: " + timeST.Result().TotalMilliseconds);
                Console.WriteLine();
                size *= 10;
            }

            Console.ReadKey();
        }

        static void BuildSB(int size)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= size; i++)
                sb.Append("a");
        }

        static void BuildST(int size)
        {
            string s = "";
            for (int i = 0; i <= size; i++)
                s += "a";
        }
    }
}
