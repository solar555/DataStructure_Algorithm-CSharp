using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.1 句点字符(.)
            //string str = "the quick brown fox jumped over the lazy dog";
            //MatchCollection matchSet = Regex.Matches(str, ".");
            //foreach (Match aMatch in matchSet)
            //    Console.WriteLine("matches at: " + aMatch.Index);

            // 1.2 句点字符(.)
            //string str = "the quick brown fox jumped over the lazy dog";
            //MatchCollection matchSet = Regex.Matches(str, "t.e");
            //foreach (Match aMatch in matchSet)
            //    Console.WriteLine("matches at: " + aMatch.Index);

            // 2. 字符类，连接号-
            //string str = "THE quick brown fox jumped over the lazy dog";
            //MatchCollection matchSet = Regex.Matches(str, "[a-z]");
            //foreach (Match match in matchSet)
            //    Console.WriteLine("Matches at: " + match.Index + " " + match.Value);

            // 3. 脱字符(^)（字符类的反或者字符类的否定）
            //string str = "THE quick brown fox jumped over the lazy dog";
            //MatchCollection matchSet = Regex.Matches(str, "[^a-z]");
            //foreach (Match match in matchSet)
            //    Console.WriteLine("Matches at: " + match.Index + " " + match.Value);

            // 4.1 如果把这三个字符类合并，就可以形成正则表达式用法中的所谓的“单词”。例如：[A-Za-z0-9]。
            //string str = "THE quick brown fox jumped over the lazy dog";
            //MatchCollection matchSet = Regex.Matches(str, "[A-Za-z0-9]");
            //foreach (Match match in matchSet)
            //    Console.WriteLine("Matches at: " + match.Index + " " + match.Value);

            // 4.2 \w：另一个用来表示“单词”的较短小的字符类
            //string str = "THE quick brown fox jumped over the lazy dog";
            //MatchCollection matchSet = Regex.Matches(str, "\\w");
            //foreach (Match match in matchSet)
            //    Console.WriteLine("Matches at: " + match.Index + " " + match.Value);

            // 4.3 \W：\w的反，表示非单词字符（比如标点符号）。
            //string str = "THE quick brown fox jumped over the lazy dog";
            //MatchCollection matchSet = Regex.Matches(str, "\\W");
            //foreach (Match match in matchSet)
            //    Console.WriteLine("Matches at: " + match.Index + " " + match.Value);

            Console.Read();
        }
    }
}
