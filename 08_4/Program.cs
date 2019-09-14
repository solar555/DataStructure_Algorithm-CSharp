using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 脱字符(^)：只能在字符串或行的开始处找到匹配
            //string[] words = new string[] { "heal", "heel", "noah", "techno" };
            //string regExp = "^h";
            //Match aMatch;
            //foreach (string word in words)
            //    if (Regex.IsMatch(word, regExp))
            //    {
            //        aMatch = Regex.Match(word, regExp);
            //        Console.WriteLine("Matched: " + word + " at position: " + aMatch.Index);
            //    }

            // 2. 美元符号($)：只在行的末尾找到匹配
            //string[] words = new string[] { "heal", "heel", "noah", "techno" };
            //string regExp = "h$";
            //Match aMatch;
            //foreach (string word in words)
            //    if (Regex.IsMatch(word, regExp))
            //    {
            //        aMatch = Regex.Match(word, regExp);
            //        Console.WriteLine("Matched: " + word + " at position: " + aMatch.Index);
            //    }

            // 3. \b：只在边缘（开始或结束）找到匹配
            //string[] words = new string[] { "heal", "heel", "noah", "techno" };
            //string regExp = "h\\b";// 开始处
            ////string regExp = "\\bh";// 结束处
            //Match aMatch;
            //foreach (string word in words)
            //    if (Regex.IsMatch(word, regExp))
            //    {
            //        aMatch = Regex.Match(word, regExp);
            //        Console.WriteLine("Matched: " + word + " at position: " + aMatch.Index);
            //    }

            Console.Read();
        }
    }
}
