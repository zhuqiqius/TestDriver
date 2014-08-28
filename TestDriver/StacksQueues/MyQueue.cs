using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.StacksQueues
{
    // Implement a MyQueue class which implements a queue using two stacks
    public class MyQueue
    {
        Stack first, second;
        const int Capacity = 100; // Capacity of a single stack
        int count;


        // Enqueque from the top of the second stack
        public void enqueue(Object item)
        {
            if (second == null)
            {
                second = new Stack();
            }
            else if (count < Capacity)
            {
                second.push(item);
            }
            else if (count >= Capacity && count < Capacity * 2)
            {
                if (first == null)
                {
                    first = new Stack();
                }
                else
                {
                    if (count == Capacity)
                    {
                        // Reshuffle the plates between first and second, so there are spaces in the second stack for push
                        ShuffleItemsInTwoStacks();
                    }
                }
                second.push(item);
            }
            else
            {
                throw new InvalidOperationException("Reach full capacity. Cannot add item to the Queue anymore");
            }

            count++;
        }

        // Dequeque from the top of the first stack
        public Object dequeueQ()
        {
            if (first == null)
            {
                first = new Stack();
            }
            else if (first.pop() == null)
            {
                ShuffleItemsInTwoStacks();
            }

            Object item = first.pop();
            count--;
            return item;
        }

        public void ShuffleItemsInTwoStacks()
        {
            List<Object> storageFirst = new List<object>();
            while (first.pop() != null)
            {
                storageFirst.Add(first.pop());
            }
            List<Object> storageSecond = new List<object>();
            while (second.pop() != null)
            {
                storageSecond.Add(second.pop());
            }

            // Push the old second's stuff to first
            for (int i = 0; i < storageSecond.Count; i++)
            {
                first.push(storageSecond[i]);
            }

            // push the old first stuff to second
            for (int i = storageFirst.Count - 1; i >= 0; i--)
            {
                second.push(storageFirst[i]);
            }
        }
    }
}
