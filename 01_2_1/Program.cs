using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Name myName = new Name("Michael", "Mason", "McMillan");
            string fullName, inits;
            fullName = myName.ToString();
            inits = myName.Initials();
            Console.WriteLine("My name is {0}.", fullName);
            Console.WriteLine("My initials are {0}.", inits);

            Console.Read();
        }
    }
}
