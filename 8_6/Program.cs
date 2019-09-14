using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "08/14/57 46 02/25/59 45 06/05/85 18" + "03/12/88 16 09/09/90 13";
            string regExp = "(?<dates>(\\d{2}/\\d{2}/\\d{2}))\\s(?<ages>(\\d{2}))\\s";
            MatchCollection matchSet = Regex.Matches(words, regExp);
            Console.WriteLine();
            foreach (Match match in matchSet)
            {
                foreach (Capture capture in match.Groups["dates"].Captures)
                    Console.WriteLine("date capture: " + capture.ToString());

                foreach (Capture capture in match.Groups["ages"].Captures)
                    Console.WriteLine("age capture: " + capture.ToString());
            }

            Console.ReadKey();
        }
    }
}
