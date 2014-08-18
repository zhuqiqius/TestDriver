using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.LinkedList
{
    // Implement an algorithm to delete a node in the middle of a singly linked list, given access only to that node
    // Example: Input: the node c from the linked list a->b->c->d->e; Result: nothing is returned, but the new linked list looks like a->b->d->e 
    public static class DeleteNodeInMiddle
    {
        public static void DeleteMiddleMan(Node middle)
        {
            // The steps are making C become of C.next.
            Node nextToMiddle = middle.next;
            middle.data = nextToMiddle.data;
            middle.next = nextToMiddle.next;
            nextToMiddle = null;
        }
    }
}
