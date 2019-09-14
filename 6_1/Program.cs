using _4_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 100;
            CArray primes = new CArray(size);
            for (int i = 0; i <= size - 1; i++)
                primes.Insert(1);

            primes.GenPrimes();
            primes.ShowPrimes();

            Console.Read();
        }
    }
}
