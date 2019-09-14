using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            MulBase(10, 2);

            Console.Read();
        }

        static void MulBase(int n, int b)
        {
            Stack digits = new Stack();
            do
            {
                digits.Push(n % b);
                n /= b;
            } while (n != 0);

            while (digits.Count > 0)
                Console.Write(digits.Pop());
        }
    }
}
