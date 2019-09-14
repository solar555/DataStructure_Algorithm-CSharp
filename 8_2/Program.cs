using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. + * ?
            //string[] words = new string[] { "bad", "baad", "boy", "fox", "jumped", "over", "the", "lazy", "dog" };
            //foreach (string word in words)
            //{
            //    if (Regex.IsMatch(word, "ba+"))
            //        Console.WriteLine("ba+ ：" + word);

            //    if (Regex.IsMatch(word, "ba*d"))
            //        Console.WriteLine("ba*d：" + word);

            //    if (Regex.IsMatch(word, "ba?d"))
            //        Console.WriteLine("ba?d ：" + word);
            //}

            // 2. {n} {n, m}
            //string[] words = new string[] { "bad", "baad", "boy", "fox", "jumped", "over", "the", "lazy", "dog" };
            //foreach (string word in words)
            //{
            //    if (Regex.IsMatch(word, "ba{2}d"))
            //        Console.WriteLine(word);

            //    if (Regex.IsMatch(word, "ba{1,3}d"))
            //        Console.WriteLine(word);

            //    if (Regex.IsMatch(word, "ba{1,}d"))
            //        Console.WriteLine(word);
            //}

            // 3.1 *贪心行为，会导致不预期的效果
            //string[] words = new string[] { "bad", "baad", "boy", "fox", "<b>jumped</b>", "over", "the", "lazy", "dog" };
            //string regExp = "<.*>";
            //MatchCollection aMatch;
            //foreach (string word in words)
            //{
            //    aMatch = Regex.Matches(word, regExp);
            //    for (int i = 0; i < aMatch.Count; i++)
            //    {
            //        Console.WriteLine(aMatch[i].Value);
            //    }
            //}

            // 3.2 利用惰性量词？可以解决这个问题
            string[] words = new string[] { "bad", "baad", "boy", "fox", "<b>jumped</b>", "over", "the", "lazy", "dog" };
            string regExp = "<.+?>";
            MatchCollection aMatch;
            foreach (string word in words)
            {
                aMatch = Regex.Matches(word, regExp);
                for (int i = 0; i < aMatch.Count; i++)
                {
                    Console.WriteLine(aMatch[i].Value);
                }
            }

            Console.ReadKey();
        }
    }
}
