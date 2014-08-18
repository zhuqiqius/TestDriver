using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.LinkedList
{
    // Write code to partition a linked list around a value x, such that all nodes less than x come before all nodes
    // greater than or equal to x.
    public static class LinkedListPartition
    {
        public static Node PartitionLinkedList(Node head, int x)
        {
            Node n = head;
            Node newLowList = new Node(0);
            Node newHighList = new Node(0);
            Node newHead = newLowList;
            Node newHighHead = newHighList;

            while(n.next != null)
            {
                if (n.data < x)
                {
                    Node nuNode = new Node(n.data);
                    newLowList.next = nuNode;
                }
                else
                {
                    Node grNode = new Node(n.data);
                    newHighList.next = grNode;
                }
                n = n.next;
                newLowList = newLowList.next;
                newHighList = newHighList.next;
            }

            // Join the low and high list together
            newLowList.next = newHighHead.next; 
            return newHead.next;
        }
    }
}
