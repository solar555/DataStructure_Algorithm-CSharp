using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            
            list.Insert("Asa1", "header");
            list.Insert("Asa2", "Asa1");

            list.PrintList();

            list.Remove("Asa2");

            Console.ReadKey();
        }
    }
}
