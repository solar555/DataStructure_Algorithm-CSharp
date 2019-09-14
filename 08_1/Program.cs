using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Match Success
            //Regex reg = new Regex("the");
            //string str = "the quick brown fox jumped over the lazy dog";
            //Match matchSet = reg.Match(str);
            //if (matchSet.Success)
            //{
            //    Console.WriteLine("found match at position: " + matchSet.Index);
            //}

            // 2. Regex.IsMatch
            //Regex reg = new Regex("the");
            //string str = "the quick brown fox jumped over the lazy dog";
            //if (Regex.IsMatch(str, "the"))
            //{
            //    Match aMatch = reg.Match(str);
            //}

            // 3. Matches MatchCollection
            //Regex reg = new Regex("the");
            //string str = "the quick brown fox jumped over the lazy dog";
            //MatchCollection matchSet = reg.Matches(str);
            //if (matchSet.Count > 0)
            //    foreach (Match item in matchSet)
            //        Console.WriteLine("found a match at: " + item.Index);

            // 4. Replace
            string str = "the quick brown fox jumped over the lazy dog";
            str = Regex.Replace(str, "brown", "black");
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
