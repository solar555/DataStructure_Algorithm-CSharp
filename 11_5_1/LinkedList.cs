using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_1
{
    public class LinkedList
    {
        protected Node header;
        public LinkedList()
        {
            header = new Node("header");
        }

        public bool IsEmpty()
        {
            return (header.Link == null);
        }

        public Node GetFirst()
        {
            return header;
        }

        public void ShowList()
        {
            Node current = header.Link;
            while (current != null)
            {
                Console.WriteLine(current.Element);
                current = current.Link;
            }
        }
    }
}
