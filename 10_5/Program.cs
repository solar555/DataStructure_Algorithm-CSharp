using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. init
            //Hashtable symbols1 = new Hashtable();
            //Hashtable symbols2 = new Hashtable(50);
            //Hashtable symbols3 = new Hashtable(25, 3.0F);

            // 2. Add
            Hashtable symbols = new Hashtable(25);
            symbols.Add("salary", 100000);
            symbols.Add("name", "David Durr");
            symbols.Add("age", 43);
            symbols.Add("dept", "Information Technology");

            // 用索引添加元素
            symbols["sex"] = "Male";
            symbols["age"] = 44;

            //// 检索键和数值
            //Console.WriteLine("Keys are: ");
            //foreach (object key in symbols.Keys)
            //    Console.WriteLine(key);
            //Console.WriteLine();

            //Console.WriteLine("Values are: ");
            //foreach (object value in symbols.Values)
            //    Console.WriteLine(value);

            //// 10.5.4 Count
            //int numElements = symbols.Count;

            //// Clear
            //symbols.Clear();

            // 删除前检查是否存在Key ContainsKey Remove
            if (symbols.ContainsKey("sex"))
                symbols.Remove("sex");

            foreach (object key in symbols.Keys)
                Console.WriteLine(key.ToString() + ": " + symbols[key].ToString());

            Console.ReadKey();
        }
    }
}
