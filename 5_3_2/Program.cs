using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. init
            Queue myQueue = new Queue(10, 2);
            // 2. add 
            for (int i = 0; i < 11; i++)
            {
                myQueue.Enqueue(i);
            }


            // 3. cw
        }
    }

    public class CQueue
    {
        private ArrayList pqueue;

        public CQueue()
        {
            pqueue = new ArrayList();
        }

        public void EnQueue(object item)
        {
            pqueue.Add(item);
        }

        public void DeQueue()
        {
            pqueue.RemoveAt(0);
        }

        public object Peek()
        {
            return pqueue[0];
        }

        public void ClearQueue()
        {
            pqueue.Clear();
        }

        public int Count()
        {
            return pqueue.Count;
        }
    }
}
