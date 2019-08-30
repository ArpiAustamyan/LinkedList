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
            public NodeTree(int newValue = 0, int newIndex = 0, NodeTree par = null, NodeTree l = null, NodeTree r = null)
            {
                value = newValue;
                parent = par;
                left = l;
                right = r;
            }
        }
        private NodeTree rute;
        private int count = 0;

        public int Count { get => count; private set => count = value; }

        public void Print()
        {
            LPR(rute);
            Console.WriteLine();
        }

        public void LPR(NodeTree ptr)
        {
            if (ptr.left != null)
            {
                LPR(ptr.left);
            }
            Console.Write(ptr.value + " ");
            Console.WriteLine(ptr.bal);
            if (ptr.right != null)
            {
                LPR(ptr.right);
            }
        }

        public void LRP(NodeTree ptr)
        {
            if (ptr.left != null)
            {
                LPR(ptr.left);
            }
            if (ptr.right != null)
            {
                LPR(ptr.right);
            }
            Console.Write(ptr.value + " ");
        }

        public void PLR(NodeTree ptr)
        {
            Console.Write(ptr.value + " ");
            if (ptr.left != null)
            {
                LPR(ptr.left);
            }
            if (ptr.right != null)
            {
                LPR(ptr.right);
            }
        }

        public void Add(int val)
        {
            if (Count == 0)
            {
                rute = new NodeTree(val);
                Count++;
                return;
            }

            Count++;
            NodeTree newItem = new NodeTree(val);
            NodeTree ptr = rute;
            while (true)
            {
                if (ptr.value > val)
                {
                    if (ptr.left == null)
                    {
                        ptr.left = newItem;
                        newItem.parent = rute;
                        break;
                    }
                    ptr = ptr.left;
                }
                else
                {
                    if (ptr.right == null)
                    {
                        ptr.right = newItem;
                        newItem.parent = ptr;
                        break;
                    }
                    ptr = ptr.right;
                }

            }
        }
    }
}
