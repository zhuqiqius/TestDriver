using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.StacksQueues
{
    //  How would you design a stack which, in addition to push and pop, 
    // also has a function min which returns the minimum element? Push, pop and min should all operate in O(1) time
    public class MinValueStack
    {
        TestDriver.LinkedList.Node top;
        int minimum;
        public Object pop()
        {
            if (top != null)
            {
                Object item = top.data;
                top = top.next;
                return item;
            }
            return null;
        }
        public void push(int item)
        {
            if (item < minimum)
            {
                minimum = item;
            }
            TestDriver.LinkedList.Node t = new TestDriver.LinkedList.Node(item);
            t.next = top;
            top = t;
        }

        public Object Minvalue()
        {
            return minimum;
        }
    }
}
