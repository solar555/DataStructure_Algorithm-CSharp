using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_2_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            CStack alist = new CStack();
            string ch;
            string word = "sees";
            bool isPalindrome = true;
            for (int i = 0; i < word.Length; i++)
                alist.Push(word.Substring(i, 1));

            int pos = 0;
            while (alist.Count > 0)
            {
                ch = alist.Pop().ToString();
                if (ch != word.Substring(pos, 1))
                {
                    isPalindrome = false;
                    break;
                }
                pos++;
            }

            if (isPalindrome)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

            Console.Read();
        }
    }

    public class CStack
    {
        private int p_index;
        private ArrayList list;

        public CStack()
        {
            list = new ArrayList();
            p_index = -1;
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public void Push(object item)
        {
            list.Add(item);
            p_index++;
        }

        public object Pop()
        {
            object obj = list[p_index];
            list.RemoveAt(p_index);
            p_index--;
            return obj;
        }

        public object Peek()
        {
            return list[p_index];
        }

        public void Clear()
        {
            list.Clear();
            p_index = -1;
        }
    }
}
