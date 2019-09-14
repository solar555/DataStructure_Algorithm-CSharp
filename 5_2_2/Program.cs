using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack nums = new Stack();
            Stack ops = new Stack();
            string expression = "5 + 10 + 15 + 20";
            Calculate(nums, ops, expression);
            Console.WriteLine(nums.Pop());

            // 5.2.6 CopyTo
            Stack myStack = new Stack();
            for (int i = 20; i > 0; i--)
                myStack.Push(i);

            object[] myArray = new object[myStack.Count];
            myStack.CopyTo(myArray, 0);

            // 5.2.6 ToArray
            Stack myStack2 = new Stack();
            for (int i = 20; i > 0; i++)
                myStack2.Push(i);

            object[] myArray2 = new object[myStack2.Count];
            myArray2 = myStack2.ToArray();

            Console.Read();
        }

        static bool IsNumeric(string input)
        {
            bool flag = true;
            string pattern = (@"^\d+$");
            Regex validate = new Regex(pattern);
            if (!validate.IsMatch(input))
                flag = false;

            return flag;
        }

        static void Calculate(Stack N, Stack O, string exp)
        {
            string ch, token = "";
            for (int i = 0; i < exp.Length; i++)
            {
                ch = exp.Substring(i, 1);
                if (IsNumeric(ch))
                    token += ch; //+=

                if (ch == " " || i == (exp.Length - 1))
                {
                    if (IsNumeric(token))
                    {
                        N.Push(token);
                        token = "";
                    }
                }
                else if (ch == "+" || ch == "-" || ch == "*" || ch == "/")
                    O.Push(ch);
                if (N.Count == 2)
                    Compute(N, O);
            }
        }

        static void Compute(Stack N, Stack O)
        {
            int oper1, oper2;
            string oper;
            oper1 = Convert.ToInt32(N.Pop());
            oper2 = Convert.ToInt32(N.Pop());
            oper = Convert.ToString(O.Pop());
            switch (oper)
            {
                case "+":
                    N.Push(oper1 + oper2);
                    break;
                case "-":
                    N.Push(oper1 - oper2);
                    break;
                case "*":
                    N.Push(oper1 * oper2);
                    break;
                case "/":
                    if (oper2 == 0)
                        N.Clear();

                    N.Push(oper1 / oper2);
                    break;
            }
        }
    }
}
