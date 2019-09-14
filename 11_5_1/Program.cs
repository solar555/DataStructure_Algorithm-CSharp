using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList MyList = new LinkedList();
            ListIterator iter = new ListIterator(MyList);
            string choice, value;
            try
            {
                iter.InsertAfter("A");
                iter.InsertAfter("B");
                iter.InsertAfter("C");
                iter.InsertAfter("D");
                iter.InsertAfter("E");
                iter.InsertAfter("F");

                while (true)
                {
                    Console.WriteLine("(n) Move to next node");
                    Console.WriteLine("(g) Get value in current ndoe");
                    Console.WriteLine("(r) Reset");
                    Console.WriteLine("(s) Show complete list");
                    Console.WriteLine("(a) Insert after");
                    Console.WriteLine("(b) Insert before");
                    Console.WriteLine("(c) Clear");
                    Console.WriteLine("(x) Exit");

                    Console.WriteLine();
                    Console.WriteLine("Enter your choice: ");
                    choice = Console.ReadLine();
                    choice = choice.ToLower();
                    char[] onechar = choice.ToCharArray();

                    switch (onechar[0])
                    {
                        case 'n':
                            if (!MyList.IsEmpty() && !iter.AtEnd())
                                iter.NextLink();
                            else
                                Console.WriteLine("Can't move to next link.");
                            break;
                        case 'g':
                            if (!MyList.IsEmpty())
                                Console.WriteLine("Element: " + iter.GetCurrent().Element);
                            else
                                Console.WriteLine("List is empty.");
                            break;
                        case 'r':
                            iter.Reset();
                            break;
                        case 's':
                            if (!MyList.IsEmpty())
                                MyList.ShowList();
                            else
                                Console.WriteLine("List is empty.");
                            break;
                        case 'a':
                            Console.WriteLine();
                            Console.Write("Enter value to insert:");
                            value = Console.ReadLine();
                            iter.InsertAfter(value);
                            break;
                        case 'b':
                            Console.WriteLine();
                            Console.Write("Enter value to insert:");
                            value = Console.ReadLine();
                            iter.InsertBefore(value);
                            break;
                        case 'c':
                            // clear the screen
                            break;
                        case 'x':
                            // end of program
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (InsertBeforeHeaderException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
