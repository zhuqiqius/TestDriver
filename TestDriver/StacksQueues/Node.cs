using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.StacksQueues
{
    public class Node
    {
        public Node next = null;
        public Object data;

        public Node(Object d)
        {
            data = d;
        }
        void appendToTail(int d)
        {
            Node end = new Node(d);
            Node n = this;
            while (n.next != null)
            {
                n = n.next;
            }
            n.next = end;
        }
    }
}
