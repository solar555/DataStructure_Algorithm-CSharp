using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 简单实例化
            //SortedList myIPs = new SortedList();
            //myIPs.Add("Mike1", "191.168.1.220");
            //myIPs.Add("Mike2", "192.168.1.220");
            //myIPs.Add("Mike3", "193.168.1.220");

            //// 使用key访问Value
            //foreach (object key in myIPs.Keys)
            //    Console.WriteLine("Name: " + key + "\n" + "IP: " + myIPs[key]);

            //Console.WriteLine();
            //Console.WriteLine();

            //// 使用索引index访问Key 和 Value
            //for (int i = 0; i < myIPs.Count; i++)
            //    Console.WriteLine("Name: " + myIPs.GetKey(i) + "\n" + "IP: " + myIPs.GetByIndex(i));

            // 2. 泛型版本
            //SortedList<string, string> myIPs = new SortedList<string, string>();
            //SortedList<string, int> gradeBook = new SortedList<string, int>();

            // 3. Remove, RemoveAt
            //SortedList myIPs = new SortedList();
            //myIPs.Add("Mike1", "191.168.1.220");
            //myIPs.Add("Mike2", "192.168.1.220");
            //myIPs.Add("Mike3", "193.168.1.220");

            //// 使用key访问Value
            //foreach (object key in myIPs.Keys)
            //    Console.WriteLine("Name: " + key + "\n" + "IP: " + myIPs[key]);

            //Console.WriteLine();
            //Console.WriteLine("Remove:");
            //myIPs.Remove("Mike1");
            //foreach (object key in myIPs.Keys)
            //    Console.WriteLine("Name: " + key + "\n" + "IP: " + myIPs[key]);

            //Console.WriteLine();
            //Console.WriteLine("RemoveAt:");
            //myIPs.RemoveAt(0);
            //foreach (object key in myIPs.Keys)
            //    Console.WriteLine("Name: " + key + "\n" + "IP: " + myIPs[key]);

            // 4. 根据Key获取Index，来存取SortedList
            SortedList myIPs = new SortedList();
            myIPs.Add("Mike3", "193.168.1.220");
            myIPs.Add("Mike1", "191.168.1.220");
            myIPs.Add("Mike2", "192.168.1.220");

            int indexMike1 = myIPs.IndexOfKey("Mike1");
            int indexIPMike1 = myIPs.IndexOfValue(myIPs["Mike1"]);
            Console.WriteLine("IndexOfKey: " + indexMike1);
            Console.WriteLine("IndexOfValue: " + indexIPMike1);

            Console.ReadKey();
        }
    }
}
