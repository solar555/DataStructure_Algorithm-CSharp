using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_1
{
    public class Node
    {
        public object Element;

        /// <summary>
        /// Forward，下一个节点链接
        /// </summary>
        public Node FLink;

        /// <summary>
        /// Backward，上一个节点链接
        /// </summary>
        public Node BLink;

        public Node()
        {
            Element = null;
            FLink = null;
            BLink = null;
        }

        public Node(object theElement)
        {
            Element = theElement;
            FLink = null;
            BLink = null;
        }
    }
}
