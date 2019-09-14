using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_1
{
    public class ListIterator
    {
        private Node current;
        private Node previous;
        LinkedList theList;
        public ListIterator(LinkedList list)
        {
            theList = list;
            current = theList.GetFirst();
            previous = null;
        }

        public void NextLink()
        {
            previous = current;
            current = current.Link;
        }

        public Node GetCurrent()
        {
            return current;
        }

        public void InsertBefore(object theElement)
        {
            Node newNode = new Node(theElement);
            if (previous.Link == null)
                throw new InsertBeforeHeaderException("Can't insert here.");
            else
            {
                newNode.Link = previous.Link;
                previous.Link = newNode;
                current = newNode;
            }
        }

        public void InsertAfter(object theElement)
        {
            Node newNode = new Node(theElement);
            newNode.Link = current.Link;
            current.Link = newNode;
            NextLink();
        }

        public void Remove()
        {
            previous.Link = current.Link;
        }

        public void Reset()
        {
            current = theList.GetFirst();
            previous = null;
        }

        public bool AtEnd()
        {
            return (current.Link == null);
        }
    }
}
