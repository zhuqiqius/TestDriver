using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.StacksQueues
{
    // Imagine a (literal) stack of plates. If the stack gets too high, it might topple. 
    // Therefore, in real life, we would likely start a new stack when the previous stack exceeds some threshold. 
    // Implement a data structure SetOf Stacks that mimics this. SetOf Stacks should be composed of several stacks and should create a new stack once the previous one exceeds capacity.
    // SetOf Stacks. push() and SetOf Stacks. pop() should behave identically to a single stack (that is, popO should return the same values as it would if there were just a single stack).
    // Follow up - Implement a function popAt(int index) which performs a pop operation on a specific sub-stack. 
    public class SetOfStacks
    {
        Node top;
        int count;
        const int Capacity = 10;
        List<Stack> stacks;
        Stack currentStack;

        public Object pop()
        {
            if (count > 1)
            {
                currentStack.pop();
                count--;
            }
            else if (top != null & count == 1)
            {
                Object item = top.data;
                int setNumber = stacks.Count - 1;
                stacks.RemoveAt(setNumber);
                currentStack = stacks[setNumber - 1];
                count = Capacity;
                return item;
            }
            return null;
        }

        //A pop operation on a specific sub-stack
        public Object popAt(int index)
        {
            Stack s = stacks.ElementAt(index);
            return s.pop();
        }

        public void push(object item)
        {
            if (count == Capacity)
            {
                Stack newStack = new Stack();
                newStack.push(item);
                stacks.Add(newStack);
                currentStack = newStack;
            }
            else
            {
                Node t = new Node(item);
                t.next = top;
                top = t;
            }
            count++;
        }
        public Object peekQ()
        {
            return top.data;
        }
    }
}
