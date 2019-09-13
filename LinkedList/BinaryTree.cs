using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class BinaryTree
    {
        public class NodeTree
        {
            public NodeTree parent;
            public int value;
            public int bal;
            public NodeTree left;
            public NodeTree right;
            public NodeTree(int newValue = 0, int newbal = 1, NodeTree par = null, NodeTree l = null, NodeTree r = null)
            {
                value = newValue;
                bal = newbal;
                parent = par;
                left = l;
                right = r;
            }
        }
        protected NodeTree root;
        private int count = 0;

        public int Count { get => count; private set => count = value; }

        public void Inorder(NodeTree ptr)
        {
            if (ptr != null)
            {
                Inorder(ptr.left);
                Console.Write(ptr.value + " ");
                Console.WriteLine(ptr.bal);
                Inorder(ptr.right);
            }
        }

        public void Postorder(NodeTree ptr)
        {
            if (ptr != null)
            {
                Postorder(ptr.left);
                Postorder(ptr.right);
                Console.Write(ptr.value + " ");
            }
        }

        public void Preorder(NodeTree ptr)
        {
            if (ptr != null)
            {
                Console.Write(ptr.value + " ");
                Preorder(ptr.left);
                Preorder(ptr.right);
            }
        }

        public bool Contains(int value)
        {
            NodeTree ptr = root;
            while (ptr != null)
            {
                if (ptr.value == value)
                    return true;
                else
                {
                    if (ptr.value > value)
                        ptr = ptr.right;
                    else
                        ptr = ptr.left;
                }
            }
            return false;
        }

        protected void AddNode(NodeTree newItem)
        {
            Add(newItem.value);
        }

        public void Add(int value)
        {
            NodeTree newItem = new NodeTree(value);
            NodeTree ptr = root;
            NodeTree parent = null;
            while (ptr != null)
            {
                parent = ptr;
                if (ptr.value > value)
                {
                    ptr = ptr.left;
                }
                else
                {
                    ptr = ptr.right;
                }
            }

            if (parent == null)
            {
                root = newItem;
            }
            else if (parent.value > newItem.value)
            {
                parent.left = newItem;
            }
            else
                parent.right = newItem;
            newItem.parent = parent;
            ChangeBalance(newItem);
        }

        protected void ChangeBalance(NodeTree ptr)
        {
            ptr = ptr.parent;
            while (ptr != null)
            {
                if (ptr.left == null || ptr.right == null)
                {
                    if (ptr.left == null)
                        ptr.bal = ptr.right.bal + 1;
                    else
                    {
                        ptr.bal = ptr.left.bal + 1;
                    }
                }
                else
                {
                    if (ptr.left.bal > ptr.right.bal)
                        ptr.bal = ptr.left.bal + 1;
                    else
                        ptr.bal = ptr.right.bal + 1;
                }
                ptr = ptr.parent;
            }
        }
        public void Print()
        {
            Inorder(root);
            Console.WriteLine();
        }

    }
}
