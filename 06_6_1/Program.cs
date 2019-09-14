using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //BitArray bitSet = new BitArray(32);
            //BitArray bitSet = new BitArray(32, true);

            // 1. 这种形式很难理解，因为BitArray最高有效位（索引为0）在最左侧的位置上。
            //byte[] ByteSet = new byte[] { 1, 2, 3, 4, 5 };
            //BitArray bitSet = new BitArray(ByteSet);
            //Console.WriteLine("count: " + bitSet.Count);

            //for (int i = 0; i <= bitSet.Count - 1; i++)
            //{
            //    Console.Write(bitSet[i] + " ");
            //    Console.WriteLine();
            //}

            // 2. 我们无法改变BitArray类所用的内部代码，但是我们可以编写外部代码来获得需要的输出。
            int bits;
            string[] binNumber = new string[8];
            int binary;

            byte[] ByteSet = new byte[] { 1, 2, 3, 4, 5 };
            BitArray bitArray = new BitArray(ByteSet);
            bits = 0;
            binary = 7;
            for (int i = 0; i <= bitArray.Count - 1; i++)

            {
                if (bitArray.Get(i) == true)
                    binNumber[binary] = "1";
                else
                    binNumber[binary] = "0";
                bits++;
                binary--;
                if((bits % 8) == 0)
                {
                    binary = 7;
                    bits = 0;
                    for (int j = 0; j <= 7; j++)
                        Console.Write(binNumber[j]);
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
