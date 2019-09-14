using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 16;
            int[] size = new int[] { 3, 4, 7, 8, 9 };
            int[] values = new int[] { 4, 5, 10, 11, 13 };

            int[] topTotalValues = new int[capacity + 1];
            int[] best = new int[capacity + 1];

            int n = values.Length;

            for (int j = 0; j <= n - 1; j++)
                for (int i = 0; i <= capacity; i++)
                    if (i >= size[j])
                        if (topTotalValues[i] < (topTotalValues[i - size[j]] + values[j]))
                        {
                            topTotalValues[i] = topTotalValues[i - size[j]] + values[j];
                            best[i] = j;
                        }

            Console.WriteLine("The maximun value is: " + topTotalValues[capacity]);
        }
    }
}
