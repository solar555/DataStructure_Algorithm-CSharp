using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            int value = int.Parse(Console.ReadLine());

            IsPrime(value);
            Console.ReadKey();
        }

        public static void IsPrime(int value)
        {
            BitArray bitSet = new BitArray(1024);
            BuildSieve(bitSet);
            if (bitSet.Get(value))
                Console.WriteLine("{0} is a prime number.", value);
            else
                Console.WriteLine("{0} is not a prime number.", value);
        }

        public static string BuildSieve(BitArray bitArray)
        {
            string primes = "";
            for (int i = 0; i <= bitArray.Count - 1; i++)
                bitArray.Set(i, true);
            int lastBit = int.Parse(Math.Sqrt(bitArray.Count).ToString());
            for (int i = 2; i <= lastBit - 1; i++)
            {
                if (bitArray.Get(i))
                    for (int j = 2 * i; j <= bitArray.Count - 1; j++)
                        bitArray.Set(j, false);
            }
            int counter = 0;
            for (int i = 1; i <= bitArray.Count - 1; i++)
                if (bitArray.Get(i))
                {
                    primes += i.ToString();
                    counter++;
                    if ((counter % 7) == 0)
                        primes += "\n";
                    else
                        primes += "\n";
                }

            return primes;
        }
    }
}
