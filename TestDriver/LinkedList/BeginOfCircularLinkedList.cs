using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.LinkedList
{
    // Given a circular linked list, implement an algorithm which returns the node at the beginning of the loop.
    // DEFINITION Circular linked list: A (corrupt) linked list in which a node's next pointer points to an earlier node, so as to make a loop in the linked list.
    // EXAMPLE
    // Input: A ->B->C->D->E-> C [the same C as earlier]
    // Output: 
    public static class BeginOfCircularLinkedList
    {
        public static Node FindBeginningOfLoop (Node head)
        {
            Node n = head;
            Node m = head;

            // Move the pointer to the last node
            while (n.next != null)
            {
                n = n.next;
            }

            int data = n.data;

            while (m.next != null)
            {
                if (m.data == data)
                {
                    break;
                }
                else
                {
                    m = m.next;
                }
            }

            return m;
        }
    }
}
