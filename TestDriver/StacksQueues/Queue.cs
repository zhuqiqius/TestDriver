using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.StacksQueues
{
    public class Queue
    {
        Node first, last;
        public void enqueue(Object item)
        {
            if (first == null)
            {
                last = new Node(item);
                first = last;
            }
            else
            {
                last.next = new Node(item);
                last = last.next;
            }
        }
        public Object dequeueQ()
        {
            if (first != null)
            {
                Object item = first.data;
                first = first.next;
                return item;
            }
            return null;
        }
    }
}
