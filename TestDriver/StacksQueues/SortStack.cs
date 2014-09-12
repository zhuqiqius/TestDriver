using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.StacksQueues
{
    // Write a program to sort a stack in ascending order (with biggest items on top). 
    // You may use at most one additional stack to hold items, but you may not copy the elements into any other data structure (such as an array). 
    // The stack supports the following operations: push, pop, peek, and isEmpty. 
    public static class SortStack
    {
        public static void SortInAscendingOrder(StackN s1)
        {
            if (s1 == null || s1.IsEmpty())
            {
                return;
            }

            int f = s1.pop();
            StackN s2 = new StackN();
            s2.push(f);

            while (!s1.IsEmpty())
            {
                int a = s1.pop();
                int b = s2.peekQ();
                
                if (a <= b)
                {
                    s2.push(a);
                }
                else
                {
                    int count = 0;
                    while (!s2.IsEmpty() && a > b)
                    {
                        int t = s2.pop();
                        s1.push(t);
                        b = s2.peekQ();
                        count++;
                    }

                    s2.push(a); // now a is in the right place

                    for (int i = 0; i < count; i++)
                    {
                        int r = s1.pop();
                        s2.push(r);
                    }
                }

                // Now s2 is sorted with smaller number on top
                while (!s2.IsEmpty())
                {
                    int u = s2.pop();
                    s1.push(u);
                }
            }
        }
    }

    public class StackN
    {
        NodeN top;
        public int pop()
        {
            if (top != null)
            {
                int item = top.data;
                top = top.next;
                return item;
            }
            return 0;
        }

        public void push(int item)
        {
            NodeN t = new NodeN(item);
            t.next = top;
            top = t;
        }

        public int peekQ()
        {
            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

    public class NodeN
    {
        public NodeN next = null;
        public int data;

        public NodeN(int d)
        {
            data = d;
        }

        void appendToTail(int d)
        {
            NodeN end = new NodeN(d);
            NodeN n = this;
            while (n.next != null)
            {
                n = n.next;
            }
            n.next = end;
        }
    }
}
