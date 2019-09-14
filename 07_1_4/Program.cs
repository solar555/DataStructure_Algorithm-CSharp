using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. charCode
            //int charCode;
            //charCode = (int)'a';
            //Console.WriteLine(charCode);

            // 2. Equals
            //string s1 = "foobar";
            //string s2 = "foobar";
            //Console.WriteLine(s1.Equals(s2));

            // 3. CompareTo
            //string s1 = "foobar";
            //string s2 = "foobar";
            //Console.WriteLine(s1.CompareTo(s2));

            //s2 = "foofoo";
            //Console.WriteLine(s1.CompareTo(s2));

            //s2 = "fooaar";
            //Console.WriteLine(s1.CompareTo(s2));

            // 4. Compare
            //string s1 = "foobar";
            ////string s2 = "foobar";
            ////string s2 = "foofoo";
            //string s2 = "fooaar";
            //int compVal = string.Compare(s1, s2);
            //switch (compVal)
            //{
            //    case 0:
            //        Console.WriteLine(s1 + " " + s2 + " are equal");
            //        break;
            //    case 1:
            //        Console.WriteLine(s1 + " is less than " + s2);
            //        break;
            //    case 2:
            //        Console.WriteLine(s1 + " is greater than " + s2);
            //        break;
            //    default:
            //        Console.WriteLine("Can't compare.");
            //        break;
            //}

            // 5. StartsWith and EndsWith
            //string[] nouns = new string[] { "cat", "dog", "bird", "eggs", "bones" };
            //ArrayList pluralNouns = new ArrayList();
            //foreach (string noun in nouns)
            //    if (noun.EndsWith("s"))
            //        pluralNouns.Add(noun);

            //foreach (string noun in pluralNouns)
            //    Console.Write(noun + " ");

            // 6. Insert, Remove
            //string s1 = "A, . B C D E.";
            //string name = "Asa";
            //int pos = s1.IndexOf(",");
            //s1 = s1.Insert(pos + 2, name);
            //Console.WriteLine(s1);

            //// Remove
            //s1 = s1.Remove(pos + 2, name.Length);
            //Console.WriteLine(s1);

            // 7. Replace, PadLeft, PadRight
            //string[] words = new string[] { "recieve", "decieve", "reciept" };
            //for (int i = 0; i <= words.GetUpperBound(0); i++)
            //{
            //    words[i] = words[i].Replace("cie", "cei");
            //    Console.WriteLine(words[i]);
            //}

            // 8.1 PadLeft, PadRight
            //string s1 = "Hello";
            //Console.WriteLine(s1.PadLeft(10));
            //Console.WriteLine("World");

            // 8.2 PadLeft, PadRight
            //string[,] names = new string[,]
            //{
            //    {"1504", "Mary", "Ella", "Steve", "Bob" },
            //    {"Mary", "Bob", "1504", "Ella", "Steve" },
            //    {"1504", "Steve", "Mary", "Ella", "Bob" },
            //};
            //Console.WriteLine();
            //Console.WriteLine();

            //for (int row = 0; row <= names.GetUpperBound(0); row++)
            //{
            //    for (int col = 0; col <= names.GetUpperBound(1); col++)
            //        Console.Write(names[row, col] + " ");
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            //for (int row = 0; row <= names.GetUpperBound(0); row++)
            //{
            //    for (int col = 0; col <= names.GetUpperBound(1); col++)
            //        Console.Write(names[row, col].PadRight(10) + " ");
            //    Console.WriteLine();
            //}

            // 9. & Concat
            //string s1 = "hello";
            //string s2 = "world";
            //string s3 = "";
            //s3 = string.Concat(s1, " ", s2);
            //Console.WriteLine(s3);

            // 10. Trim and TrimEnd
            //string[] names = new string[] { "1504", " Mary", "Ella ", " Steve", "Bob " };
            //Console.WriteLine();
            //ShowName(names);
            //Console.WriteLine();
            //TrimValues(names);
            //Console.WriteLine();
            //ShowName(names);

            // 10.2 trim html comments with Trim and TrimEnd
            //string[] htmlComments = new string[]
            //{
            //    "<!-- Start Page Number Function1 -->",
            //    "<!-- Start Page Number Function2 -->",
            //};
            //char[] commentChars = new char[] { '<', '!', '-', '>' };
            //for (int i = 0; i <= htmlComments.GetUpperBound(0); i++)
            //{
            //    htmlComments[i] = htmlComments[i].Trim(commentChars);
            //    htmlComments[i] = htmlComments[i].TrimEnd(commentChars);
            //}
            //for (int i = 0; i <= htmlComments.GetUpperBound(0); i++)
            //    Console.WriteLine("Comment: " + htmlComments[i]);

            Console.Read();
        }

        public static void ShowName(string[] names)
        {
            foreach (var name in names)
                Console.Write(name);
        }

        public static void TrimValues(string[] arr)
        {
            char[] charArr = new char[] { ' ' };
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                arr[i] = arr[i].Trim(charArr[0]);
                arr[i] = arr[i].TrimEnd(charArr[0]);
            }
        }
    }
}
