using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 第一个例子
            //string str1 = "Hello, World!";
            //int len = str1.Length;
            //int pos = str1.IndexOf(" ");
            //string firstWord, lastWord;
            //firstWord = str1.Substring(0, pos - 1);
            //lastWord = str1.Substring(pos + 1, len - 1 - (pos + 1));

            //Console.WriteLine(firstWord);
            //Console.WriteLine(lastWord);
            //Console.Read();

            // 2. 获取字符串中的单词，并添加到一个列表
            //string str2 = "A B C D E F G";
            //var list = GetWordList(str2);
            //for (int i = 0; i < list.Count; i++)
            //    Console.WriteLine(list[i]);

            //Console.Read();

            // 7.1.3 Split and Join
            string data = "A,B,C,D,E,F,G";
            string[] sData;
            char[] delimiter = new char[] { ',' };
            sData = data.Split(delimiter, data.Length);
            //sData = data.Split(delimiter, 2);
            foreach (string word in sData)
                Console.WriteLine(word);

            string joined;
            joined = String.Join(",", sData);
            Console.WriteLine(joined);

            Console.Read();
        }

        public static ArrayList GetWordList(string str)
        {
            int pos;
            string word;
            ArrayList words = new ArrayList();
            pos = str.IndexOf(" ");
            while(pos > 0)
            {
                word = str.Substring(0, pos);
                words.Add(word);

                str = str.Substring(pos + 1, str.Length - (pos + 1));
                pos = str.IndexOf(" ");
                if (pos == -1)
                {
                    word = str.Substring(0, str.Length);
                    words.Add(word);
                }
            }

            return words;
        }
    }
}
