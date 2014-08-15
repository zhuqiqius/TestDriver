using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.LinkedList
{
    // Write code to remove duplicates from an unsorted linked list.
    // How would you solve this problem if a temporary buffer is not allowed?
    public static class RemoveDuplicates
    {
        public static Node RemoveDuplicatesFromUnSortedLinkedList(Node head)
        {
            List<int> buffer = new List<int>();
            Node n = head;
            buffer.Add(head.data);

            while (n.next != null)
            {
                foreach (int number in buffer)
                {
                    if (n.next.data != number)
                    {
                        buffer.Add(n.data);
                    }
                    else
                    {
                        n.next = n.next.next;
                    }
                }
                n = n.next;
            }
            return head;
        }

        public static void RemoveLinkedListDuplicatesNoBuffer(Node head)
        {
            // Having two pointers, one stay at certain node, the other one is moving to next
            Node n = head;
            while (n.next != null)
            {
                int value = n.data;
                Node m = n;
                while (m.next != null)
                {
                    if (m.next.data != n.data)
                    {
                        m = m.next;
                    }
                    else
                    {
                        m.next = m.next.next;
                    }
                }
                n = n.next;
            }
        }
    }
}


