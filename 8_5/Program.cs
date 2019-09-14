using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8.5 分组构造
            // 使用圆括号的正则表达式

            // 8.5.1 匿名组
            // 示例：下面是生日和年龄的字符串，正则只匹配年龄，且年龄两边是空格
            // 备注：\s代表空格
            //string words = "08/14/57 46 02/25/59 45 06/05/85 18" + "03/12/88 16 09/09/90 13";
            //string regExp = "(\\s\\d{2}\\s)";
            //MatchCollection matchSet = Regex.Matches(words, regExp);
            //foreach (Match match in matchSet)
            //    Console.WriteLine(match.Groups[0].Captures[0]);

            // 8.5.2 命名组
            //string words = "08/14/57 46 02/25/59 45 06/05/85 18" + "03/12/88 16 09/09/90 13";
            //string regExp = "(?<dates>(\\d{2}/\\d{2}/\\d{2}))\\s";
            //MatchCollection matchSet = Regex.Matches(words, regExp);
            //foreach (Match match in matchSet)
            //    Console.WriteLine("Date: {0}", match.Groups["dates"]);

            // 8.5.3 正向预搜索断言
            //string words = "lions lion tigers tiger bears,bear";
            //string regExp = "\\w+(?=\\s)";
            //MatchCollection matchSet = Regex.Matches(words, regExp);
            //foreach (Match match in matchSet)
            //    Console.WriteLine(match.Value);

            // 8.5.3 负的正向预搜索断言
            //string words = "subroutine routine subprocedure procedure";
            //string regExp = "\\b(?!sub)\\w+\\b";
            //MatchCollection matchSet = Regex.Matches(words, regExp);
            //foreach (Match match in matchSet)
            //    Console.WriteLine(match.Value);

            // 8.5.3 反向预搜索断言
            //string words = "subroutines routine subprocedures procedure";
            //string regExp = "\\b\\w+(?<=s)\\b";
            //MatchCollection matchSet = Regex.Matches(words, regExp);
            //foreach (Match match in matchSet)
            //    Console.WriteLine(match.Value);

            // 8.5.3 负的反向预搜索断言
            string words = "subroutines routine subprocedures procedure";
            string regExp = "\\b\\w+(?<!s)\\b";
            MatchCollection matchSet = Regex.Matches(words, regExp);
            foreach (Match match in matchSet)
                Console.WriteLine(match.Value);

            Console.ReadKey();
        }
    }
}
