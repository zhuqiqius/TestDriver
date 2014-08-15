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
                if (n.next.data != buffer.ElementAt(0))
                {
                    buffer.Add(n.data);
                }
                else
                {

                }
            }
            return head;
        }
    }
}


