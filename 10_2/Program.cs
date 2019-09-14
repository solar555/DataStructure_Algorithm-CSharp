using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[99];
            string name;
            string[] someNames = new string[] { "David", "Jennifer", "Donnie", "Mayo", "Raymond", "Bernica", "Mike", "Clayton", "Beata", "Michael" };
            int hashVal;
            for (int i = 0; i < 10; i++)
            {
                name = someNames[i];
                hashVal = BetterHash(name, names);
                names[hashVal] = name;
            }
            ShowDistrib(names);

            Console.ReadKey();
        }

        static int SimpleHash(string s, string[] arr)
        {
            int tot = 0;
            char[] cname = s.ToCharArray();
            for (int i = 0; i <= cname.GetUpperBound(0); i++)
                tot += cname[i];

            Console.WriteLine("name: " + s);
            Console.WriteLine("cname: " + cname);
            Console.WriteLine("tot: " + tot);
            Console.WriteLine("arr.GetUpperBound(0): " + arr.GetUpperBound(0));

            return tot % arr.GetUpperBound(0);
        }

        static int BetterHash(string s, string[] arr)
        {
            long tot = 0;
            char[] cname = s.ToCharArray();
            for (int i = 0; i <= cname.GetUpperBound(0); i++)
                tot += 37 * tot + cname[i];

            tot = tot % arr.GetUpperBound(0);
            if (tot < 0)
                tot += arr.GetUpperBound(0);
            return (int)tot;
        }

        static void ShowDistrib(string[] arr)
        {
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
                if (arr[i] != null)
                    Console.WriteLine(i + " " + arr[i]);
        }

        static bool InHash(string s, string[] arr)
        {
            int hval = BetterHash(s, arr);
            if (arr[hval] == s)
                return true;
            else
                return false;
        }
    }
}
