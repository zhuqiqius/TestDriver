using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDriver.LinkedList;

namespace TestDriver.StacksQueues
{
    public class Stack
    {
        Node top;
        public Object pop()
        {
            if (top != null)
            {
                Object item = top.data; top = top.next;
                return item;
            }
            return null;
        }
        public void push(object item)
        {
            Node t = new Node(item);
            t.next = top;
            top = t;
        }
        public Object peekQ()
        {
            return top.data;
        }
    }
}
