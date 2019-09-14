using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "08/14/57 46 02/25/59 45 06/05/85 18" + "03/12/88 16 09/09/90 13";
            MatchCollection matchSet = Regex.Matches(words, "\\d{2}/\\d{2}/\\d{2}\\s", RegexOptions.Multiline);
            foreach (Match match in matchSet)
                Console.WriteLine(match.Value);
            Console.ReadKey();
        }
    }
}
