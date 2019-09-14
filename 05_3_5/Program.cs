using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            PQueue erwait = new PQueue();
            PQueueItem[] erPatient = new PQueueItem[3];
            PQueueItem nextPatient;
            erPatient[0].name = "A";
            erPatient[0].priority = 1;

            erPatient[1].name = "B";
            erPatient[1].priority = 0;

            erPatient[2].name = "C";
            erPatient[2].priority = 3;

            for (int i = 0; i <= erPatient.GetUpperBound(0); i++)
                erwait.Enqueue(erPatient[i]);

            nextPatient = (PQueueItem)erwait.Dequeue();
            Console.WriteLine(nextPatient.name);
            Console.Read();
        }
    }

    public struct PQueueItem
    {
        public int priority;
        public string name;
    }

    public class PQueue: Queue
    {
        public PQueue()
        {

        }

        public override object Dequeue()
        {
            object[] items;
            int min;
            items = this.ToArray();
            min = ((PQueueItem)items[0]).priority;
            for (int i = 0; i <= items.GetUpperBound(0); i++)
            {
                var p = ((PQueueItem)items[i]).priority;
                if (p < min)
                    min = p;
            }
            Clear();

            for (int j = 0; j <= items.GetUpperBound(0); j++)
            {
                var item = ((PQueueItem)items[j]);
                if (item.priority == min && item.name != "")
                    Enqueue(items[j]);
            }

            return base.Dequeue();
        }
    }
}
