using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3
{
    public class LinkedList
    {
        private Node header;
        public LinkedList()
        {
            header = new Node("header");
        }

        private Node Find(object item)
        {
            Node current = new Node();
            current = header;
            while (current.Element != item)
                current = current.Link;

            return current;
        }

        public void Insert(object newItem, object backwardItem)
        {
            Node newNode = new Node(newItem);
            Node backwardNode = Find(backwardItem);

            newNode.Link = backwardNode.Link;
            backwardNode.Link = newNode;
        }

        private Node FindPrevious(object element)
        {
            Node preNode = header;

            // 不是最后一个Node，同时下一个节点的元素不是element，就继续遍历
            while (!(preNode.Link == null) && (preNode.Link.Element != element))
                preNode = preNode.Link;

            return preNode;
        }

        public void Remove(object element)
        {
            Node p = FindPrevious(element);
            if (p.Link != null)
                p.Link = p.Link.Link;
        }

        public void PrintList()
        {
            Node current = new Node();
            current = header;
            while (!(current.Link == null))
            {
                Console.WriteLine(current.Link.Element);
                current = current.Link;
            }
        }
    }
}
