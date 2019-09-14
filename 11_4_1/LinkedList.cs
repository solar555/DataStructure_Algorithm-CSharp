using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_1
{
    public class LinkedList
    {
        private Node header;

        public LinkedList()
        {
            header = new Node("header");
        }

        private Node Find(object element)
        {
            Node current = new Node();
            current = header;
            while (current.Element != element)
                current = current.FLink;

            return current;
        }

        public void Insert(object newItem, object backwardItem)
        {
            Node newNode = new Node(newItem);
            Node backwardNode = Find(backwardItem);

            newNode.FLink = backwardNode.FLink;
            newNode.BLink = backwardNode;
            backwardNode.FLink = newNode;
        }

        public void Remove(object element)
        {
            Node node = Find(element);
            if (node.FLink != null)
            {
                node.BLink.FLink = node.FLink;
                node.FLink.BLink = node.BLink;
                node.FLink = null;
                node.BLink = null;
            }
        }

        private Node FindLast()
        {
            Node current = new Node();
            current = header;
            while (current.FLink != null)
                current = current.FLink;

            return current;
        }

        public void PrintList()
        {
            Node current = header;
            while (current.FLink != null)
            {
                Console.WriteLine(current.FLink.Element);
                current = current.FLink;
            }
        }

        public void PrintReverse()
        {
            Node current = current = FindLast();
            while (current.BLink != null)
            {
                Console.WriteLine(current.Element);
                current = current.BLink;
            }
        }
    }
}
