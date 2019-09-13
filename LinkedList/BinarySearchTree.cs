using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class BinarySearchTree : BinaryTree
    {

        public int Height(NodeTree N)
        {
            if (N == null)
                return 0;
            return N.bal;
        }

        public int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public int GetBalance(NodeTree N)
        {
            if (N == null)
                return 0;
            return Height(N.left) - Height(N.right);
        }

        public new void Add(int value)
        {
            root = AddP(root, value);
        }

        private NodeTree AddP(NodeTree node, int value)
        {
            if (node == null)
                return (new NodeTree(value));

            if (value < node.value)
                node.left = AddP(node.left, value);
            else if (value > node.value)
                node.right = AddP(node.right, value);
            else
                return node;

            node.bal = 1 + Max(Height(node.left),
                                Height(node.right));

            int balance = GetBalance(node);
            if (balance > 1)
            {
                if (GetBalance(node.left) > 0)
                {
                    node = RotateLL(node);
                }
                else
                {
                    node = RotateLR(node);
                }
            }
            else if (balance < -1)
            {
                if (GetBalance(node.right) > 0)
                {
                    node = RotateRL(node);
                }
                else
                {
                    node = RotateRR(node);
                }
            }
            return node;
        }

        private NodeTree RotateRR(NodeTree parent)
        {
            NodeTree pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            parent.bal = Max(Height(parent.left),
                            Height(parent.right)) + 1;
            pivot.bal = Max(Height(pivot.left),
                            Height(pivot.right)) + 1;
            return pivot;
        }

        private NodeTree RotateLL(NodeTree parent)
        {
            NodeTree pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            parent.bal = Max(Height(parent.left),
                           Height(parent.right)) + 1;
            pivot.bal = Max(Height(pivot.left),
                              Height(pivot.right)) + 1;
            return pivot;
        }
        private NodeTree RotateLR(NodeTree parent)
        {
            NodeTree pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private NodeTree RotateRL(NodeTree parent)
        {
            NodeTree pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }

        public void Delete(int value)
        {
            root = Delete(root, value);
        }

        private NodeTree Delete(NodeTree node, int target)
        {
            NodeTree parent;
            if (node == null)
            { return null; }
            else
            {

                if (target < node.value)
                {
                    node.left = Delete(node.left, target);
                    if (GetBalance(node) == -2)
                    {
                        if (GetBalance(node.right) <= 0)
                        {
                            node = RotateRR(node);
                        }
                        else
                        {
                            node = RotateRL(node);
                        }
                    }
                }

                else if (target > node.value)
                {
                    node.right = Delete(node.right, target);
                    if (GetBalance(node) == 2)
                    {
                        if (GetBalance(node.left) >= 0)
                        {
                            node = RotateLL(node);
                        }
                        else
                        {
                            node = RotateLR(node);
                        }
                    }
                }

                else
                {
                    if (node.right != null)
                    {

                        parent = node.right;
                        while (parent.left != null)
                        {
                            parent = parent.left;
                        }
                        node.value = parent.value;
                        node.right = Delete(node.right, parent.value);
                        if (GetBalance(node) == 2)
                        {
                            if (GetBalance(node.left) >= 0)
                            {
                                node = RotateLL(node);
                            }
                            else
                            {
                                node = RotateLR(node);
                            }
                        }
                    }
                    else
                    {
                        return node.left;
                    }
                }
            }
            return node;
        }

    }
}
