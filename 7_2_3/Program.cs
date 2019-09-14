using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Append
            //StringBuilder sb = new StringBuilder();
            //string[] words = new string[] { "now ", "is ", "the ", "time ", "for ", "all" };
            //for (int i = 0; i <= words.GetUpperBound(0); i++)
            //    sb.Append(words[i]);

            //Console.WriteLine(sb);

            // 2. format string
            //StringBuilder sb = new StringBuilder();
            //Console.WriteLine();
            //sb.AppendFormat("Your order is for {0000} widgets.", 234);
            //sb.AppendFormat("\nWe have {0000} widgets left.", 12);
            //Console.WriteLine(sb);

            // 3.1 Insert
            //StringBuilder sb = new StringBuilder();
            //sb.Insert(0, "Hello");
            //sb.Append("world");
            //sb.Insert(5, ", ");
            //Console.WriteLine(sb);
            //char[] chars = new char[] { 't', 'h', 'e', 'r', 'e' };
            //sb.Insert(5, " " + new string(chars));
            //Console.WriteLine(sb);

            // 3.2 Insert times
            //StringBuilder sb = new StringBuilder();
            //sb.Insert(0, "and on ", 6);
            //Console.WriteLine(sb);

            // 4. Remove
            //StringBuilder sb = new StringBuilder("noise in+++++ string");
            //sb.Remove(8, 5);
            //Console.WriteLine(sb);

            // 5. Replace
            //StringBuilder sb = new StringBuilder("recieve decieve reciept");
            //sb.Replace("cie", "cei");
            //Console.WriteLine(sb);

            // 6. ToString()
            StringBuilder sb = new StringBuilder("HELLO WORLD");
            string st = sb.ToString();
            st = st.ToLower();
            st = st.Replace(st.Substring(0, 1), st.Substring(0, 1).ToUpper());
            sb.Replace(sb.ToString(), st);
            Console.WriteLine(sb);

            Console.ReadKey();
        }
    }
}
