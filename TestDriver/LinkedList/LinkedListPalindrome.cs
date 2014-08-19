using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.LinkedList
{
    // Implement a function to check if a linked list is a palindrome
    public static class LinkedListPalindrome
    {
        public static bool CheckIfPalindrome (Node head)
        {
            Node n = head;
            List<int> stor = new List<int>();

            // Move the pointer to the last node
            while (n.next != null)
            {
                stor.Add(n.data);
                n = n.next;
            }

            for (int i = 0; i < stor.Count / 2; i++)
            {
                if (stor.ElementAt(i) != stor.ElementAt(stor.Count -1 - i))
                {
                    return false;
                } 
            }
            return true;
        }
    }
}
