using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList names = new ArrayList();
            names.Add("A1");
            names.Add("A2");
            names.Add("A3");
            Console.WriteLine("name list is:");
            foreach (object name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            string[] newNames = new string[] { "B1", "B2" };
            ArrayList moreNames = new ArrayList();
            moreNames.Add("C1");
            moreNames.Add("C2");
            moreNames.Add("C3");

            names.InsertRange(0, newNames);
            names.AddRange(moreNames);
            Console.WriteLine("name list is:");
            foreach (object name in names)
            {
                Console.WriteLine(name);
            }

            ArrayList someName = new ArrayList();
            someName = names.GetRange(2, 4);
            Console.WriteLine("someName is: ");
            foreach (object name in someName)
            {
                Console.WriteLine(name);
            }

            object[] arrNames;
            arrNames = names.ToArray();
            Console.WriteLine("arrNames is: ");
            for (int i = 0; i <= arrNames.GetUpperBound(0); i++)
            {
                Console.WriteLine(arrNames[i]);
            }

            Console.ReadKey();
        }

        static int sumNums(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i <= nums.GetUpperBound(0); i++)
            {
                sum += nums[i];
            }

            return sum;
        }
    }
}
