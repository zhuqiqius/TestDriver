using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.StacksQueues
{
    // In the classic problem of the Towers of Hanoi, you have 3 towers and N disks of different sizes which can slide onto any tower. 
    // The puzzle starts with disks sorted in ascending order of size from top to bottom (i.e., each disk sits on top of an even larger one). 
    // You have the following constraints:
    // (1) Only one disk can be moved at a time.
    // (2) A disk is slid off the top of one tower onto the next tower.
    // (3) A disk can only be placed on top of a larger disk.
    // Write a program to move the disks from the first tower to the last using stacks
    public class TowerOfHanoiDiskSliding
    {
        StackOfDisks first, second, third;
        const int Capacity = 100; // Capacity of a single stack
        int count;

        // Move the nth disk of the first tower
        public void MoveDiskFromFirstTowerToLast(int n)
        {
            if (first == null || n == 0)
            {
                return;
            }

            // Pop the disks that's smaller than n in the 1st stack
            List<int> firstDisks = PopDisksFromtheStackAboveDiskN(first, n);

            // Get disk N from the 1st stack
            int diskN = first.pop();

            // Put the disks back into the 1st stack
            PushDisksBackTotheStack(first, firstDisks);

            if (second != null)
            {
                // Insert diskN to the 2nd stack
                List<int> secDisks = InsertDiskIntoAStack(second, diskN, false);

                // Put the disks back into the 2nd stack
                PushDisksBackTotheStack(second, secDisks);
            }

            if (third == null)
            {
                third = new StackOfDisks();
            }

            // Insert diskN to the 3rd stack
            List<int> thdDisks = InsertDiskIntoAStack(third, diskN, true);

            // Put the disks back into the 3rd stack
            PushDisksBackTotheStack(third, thdDisks);
        }

        public List<int> PopDisksFromtheStackAboveDiskN(StackOfDisks s, int n)
        {
            List<int> disks = new List<int>();
            for (int i = 1; i < n; i++)
            {
                int diameter = first.pop();
                disks.Add(diameter);
            }
            return disks;
        }

        public List<int> PushDisksBackTotheStack(StackOfDisks s, List<int> disks)
        {
            for (int i = disks.Count - 1; i >= 0; i--)
            {
                s.push(disks[i]);
            }
            return disks;
        }

        public List<int> InsertDiskIntoAStack(StackOfDisks s, int diamterOfDisk, bool putdown)
        {
            List<int> disks = new List<int>();
            while (true)
            {
                int d = s.pop();
                if (d < diamterOfDisk)
                {
                    disks.Add(d);
                }
                else
                {
                    s.push(d); // Put the bigger disk back to stack
                    if (putdown)
                    {
                        s.push(diamterOfDisk); // put the diskN to the stack
                    }
                    break;
                }
            }
            return disks;
        }
    }

    public class Disk
    {
        public Disk next = null;
        public int diameter;

        public Disk(int d)
        {
            diameter = d;
        }
        void appendToTail(int d)
        {
            Disk end = new Disk(d);
            Disk n = this;
            while (n.next != null)
            {
                n = n.next;
            }
            n.next = end;
        }
    }

    public class StackOfDisks
    {
        Disk top;
        public int pop()
        {
            if (top != null)
            {
                int item = top.diameter;
                top = top.next;
                return item;
            }
            return 0;
        }
        public void push(int item)
        {
            Disk t = new Disk(item);
            t.next = top;
            top = t;
        }
        public int peekQ()
        {
            return top.diameter;
        }
    }
}
