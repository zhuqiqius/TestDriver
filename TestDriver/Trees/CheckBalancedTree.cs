using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDriver.Trees
{
    // Implement a function to check if a binary tree is balanced. For the purposes of this question, 
    // a balanced tree is defined to be a tree such that the heights of the two subtrees of any node never differ by more than one
    public class CheckBalancedTree
    {
        public bool IsBinaryTree(TNode root)
        {
            if (root == null)
            {
                return false;
            }

            int leftL = 0;
            if (root.left != null)
            {
                leftL = GetTreeLength(root.left, out leftL);
            }

            int rightL = 0;
            if (root.right != null)
            {
                rightL = GetTreeLength(root.right, out rightL);
            }

            int diff = Math.Abs(leftL - rightL);
            return (diff <= 1);
        }

        private int GetTreeLength(TNode tNode, out int length)
        {
            length = 0;
            if (tNode.HasChildren)
            {
                length++;
            }

            if (tNode.left != null)
            {
                GetTreeLength(tNode.left, out length);
            }

            if (tNode.right != null)
            {
                GetTreeLength(tNode.right, out length);
            }

            return length;
        }
    }

    public class TNode
    {
        public TNode left { get; set; }
        public TNode right { get; set; }

        public bool IsLeafNode
        {
            get
            {
                return (left == null && right == null); 
            }
        }

        public bool HasChildren
        {
            get
            {
                return (left != null || right != null);
            }
        }
    }
}
