using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_2
{
    public class Node
    {
        public object Element;
        public Node Link;
        public Node()
        {
            Element = null;
            Link = null;
        }

        public Node(object TheElement)
        {
            Element = TheElement;
            Link = null;
        }
    }
}
