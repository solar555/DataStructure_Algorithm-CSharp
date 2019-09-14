using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_2
{
    public class LinkedList
    {
        protected Node current;
        protected Node header;
        private int count;
        public LinkedList()
        {
            count = 0;
            header = new Node("header");
            header.Link = header;
        }

        public bool IsEmpty()
        {
            return (header.Link == null);
        }

        public void MakeEmpty()
        {
            header.Link = null;
        }

        public void PrintList()
        {
            Node current = header;
            while (current.Link.Element.ToString() != "header")
            {
                Console.WriteLine(current.Link.Element);
                current = current.Link;
            }
        }

        private Node FindPrevious(object element)
        {
            Node current = header;
            while (current.Link != null && current.Link.Element != element)
                current = current.Link;

            return current;
        }

        private Node Find(object element)
        {
            Node current = header.Link;
            while (current.Element != element)
                current = current.Link;

            return current;
        }

        public void Remove(object element)
        {
            Node preNode = FindPrevious(element);
            if (preNode.Link != null)
                preNode.Link = preNode.Link.Link;

            count--;
        }

        public void Insert(object n1, object n2)
        {
            Node newNode = new Node(n1);
            Node current = Find(n2);

            newNode.Link = current.Link;
            current.Link = newNode;
            count++;
        }

        public void InsertFirst(object n)
        {
            Node current = new Node(n);
            current.Link = header;
            header.Link = current;
            count++;
        }

        public Node Move(int num)
        {
            Node current = header.Link;
            Node temp;
            for (int i = 0; i <= num; i++)
                current = current.Link;

            if (current.Element.ToString() == "header")
                current = current.Link;

            temp = current;
            return temp;
        }

        public Node GetFirst()
        {
            return header;
        }
    }
}
