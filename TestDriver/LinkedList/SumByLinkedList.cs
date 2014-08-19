using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.LinkedList
{
    // You have two numbers represented by a linked list, where each node contains a single digit. 
    // The digits are stored in reverse order, such that the 1s digit is at the head of the list. 
    // Write a function that adds the two numbers and returns the sum as a linked list.
    // EXAMPLE
    // Input: (7-> 1 -> 6) + (5 -> 9 -> 2).That is, 617 + 295.
    // Output: 2 -> 1 -> 9.That is, 912.
    // FOLLOW UP
    // Suppose the digits are stored in forward order. Repeat the above problem.
    // EXAMPLE
    // Input: (6 -> 1 -> 7) + (2 -> 9 -> 5).That is, 617 + 295.
    // Output: 9 -> 1 -> 2.That is, 912
    public static class SumByLinkedList
    {
        public static Node AddTwoReverseLinkedList(Node h1, Node h2)
        {
            Node m = h1;
            Node n = h2;
            Node newHead = new Node(0);
            Node s = newHead;
            int flag = 0;

            while (m.next != null && n.next != null)
            {
                int sum = m.data + n.data;
                if (sum >= 10)
                {
                    sum = sum - 10;
                }

                if (m.next.data + n.next.data >= 10)
                {
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }

                Node newNode = new Node(sum + flag);
                s.next = newNode;

                m = m.next;
                n = n.next;
                s = s.next;
            }

            // In case of m.length != n.length
            if (m.next != null)
            {
                while (m.next != null)
                {
                    s.next = m.next;

                    s = s.next;
                    m = m.next;
                }
            }

            if (n.next != null)
            {
                while (n.next != null)
                {
                    s.next = n.next;

                    s = s.next;
                    n = n.next;
                }
            }

            return newHead.next;
        }

        public static Node AddTwoForwardLinkedList(Node h1, Node h2)
        {
            Node m = h1;
            Node n = h2;
            bool moveup;
            Node newHead;
            if (h1.data + h2.data > 10)
            {
                newHead = new Node(1);
                moveup = true;
            }
            else
            {
                newHead = new Node(1);
                moveup = false;
            }
            Node s = newHead;
            int flag = 0;

            while (m.next != null && n.next != null)
            {
                int sum = m.data + n.data;
                if (sum >= 10)
                {
                    flag = 1;
                    sum = sum - 10;
                }
                else
                {
                    flag = 0;
                }
                Node newNode = new Node(sum + flag);
                s.next = newNode;

                m = m.next;
                n = n.next;
                s = s.next;
            }

            if (m.next != null)
            {
                while (m.next != null)
                {
                    s.next = m.next;

                    s = s.next;
                    m = m.next;
                }
            }

            if (n.next != null)
            {
                while (n.next != null)
                {
                    s.next = n.next;

                    s = s.next;
                    n = n.next;
                }
            }

            if (moveup)
            {
                return newHead;
            }
            else
            {
                return newHead.next;
            }
        }
    }
}
