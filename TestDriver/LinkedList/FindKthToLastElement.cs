using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.LinkedList
{
    // Implement an algorithm to find the kth to last element of a singly linked list
    public static class FindKthToLastElement
    {
        public static List<int> FindElementToLast(Node head, int k)
        {
            List<int> list = new List<int>();
            Node n = head;
            int i = 1;
            while (n.next != null)
            {
                i++;
                if (i >= k)
                {
                    list.Add(n.data);
                }
                n = n.next;
            }
            return list;
        }
    }
}
