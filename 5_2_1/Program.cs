using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            Stack<string> myStringStack = new Stack<string>();

            string[] names = new string[] { "A", "B", "C" };
            Stack nameStack = new Stack(names);

            Stack myStackWithInitCapacity = new Stack(25);

        }
    }
}
