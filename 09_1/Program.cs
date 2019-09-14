using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 默认构造器
            //IPAddresses myIPs = new IPAddresses();
            //myIPs.Add("Mike1", "191.155.12.1");
            //myIPs.Add("Mike2", "192.155.12.1");
            //myIPs.Add("Mike3", "193.155.12.1");

            //Console.WriteLine("There are " + myIPs.Count + "IP addresses");
            //Console.WriteLine("Mike2's ip address: " + myIPs.Item("Mike2"));
            //myIPs.Clear();
            //Console.WriteLine("There are " + myIPs.Count + "IP addresses");

            // 2. 自定义构造器
            //for (int i = 0; i < 4; i++)
            //    Console.WriteLine();

            //IPAddresses myIPs = new IPAddresses(@"D:\ips.txt");
            //Console.WriteLine("count:" + myIPs.Count);
            //Console.WriteLine("Mike2's ip: " + myIPs.Item("Mike2"));

            // 3. CopyTo
            IPAddresses myIPs = new IPAddresses(@"D:\ips.txt");
            Console.WriteLine(myIPs.Count);
            DictionaryEntry[] ips = new DictionaryEntry[myIPs.Count];
            myIPs.CopyTo(ips, 0);

            for (int i = 0; i <= ips.GetUpperBound(0); i++)
            {
                Console.WriteLine(ips[i].Key);
                Console.WriteLine(ips[i].Value);
            }

            Console.Read();
        }
    }
}
